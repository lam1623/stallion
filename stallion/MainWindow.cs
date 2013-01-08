using System;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Gtk;
using Gdk;
using System.Globalization;
using System.Xml;
using Mono.Unix;
using Notifications;
using System.Collections.Generic;


public partial class MainWindow : Gtk.Window
{      
	private stallion.xmlfile xmlfile = new stallion.xmlfile();
    private stallion.SelectFileAndFolder selectfileandfolder;
	
    private List<stallion.Video> videos = new List<stallion.Video>();	
	private List<stallion .Video> selectedNodes = new List<stallion.Video>();
	
    private string HomeDir = Environment.GetEnvironmentVariable("HOME");    
    private string XmlOptions = stallion.MainClass.GetExecutablePath()+"/presets.xml";	
    private string lbl6_label;
    private string lbl7_label;
    private string lbl8_label;
    private string lbl9_label;
    private string lbl11_label;
    private string lbl12_label;
	
    public MainWindow () : base(Gtk.WindowType.Toplevel)
    {
        Build ();
        Application.Init ();
		
		Modal = true;
        
        Catalog.Init("i8n1","locale/");
        
        if (!xmlfile.XmlExits())                        
        {       
                if (System.IO.Directory.Exists(HomeDir+"/.stallion"))
                        System.IO.Directory.CreateDirectory(HomeDir+"/.stallion");
                xmlfile.CreateXmlFile();
                xmlfile.SetXmlFile("aplicacion","DirSave",HomeDir);     
                xmlfile.SetXmlFile("aplicacion","DirOpen",HomeDir);
                xmlfile.SetXmlFile("aplicacion","ComboCV","-1");
                xmlfile.SetXmlFile("aplicacion","ComboVA","-1");
                xmlfile.SetXmlFile("option","loadsubtitle","True");
                xmlfile.SetXmlFile("option","closetray","False");
                xmlfile.SetXmlFile("option","infoend","False");         
                xmlfile.SetXmlFile("option","poweroff","False");
				xmlfile.SetXmlFile("option","notShowDeleteDialog","true");
        }               
        
        if (File.Exists(xmlfile.GetXmlFile("unix","PresetXml")))
                XmlOptions = xmlfile.GetXmlFile("unix","PresetXml");
        else
                xmlfile.SetXmlFile("unix","PresetXml",XmlOptions);
        
        ReadXml ("AddCategory",null);
        
        combobox1.Active = int.Parse(xmlfile.GetXmlFile("aplicacion","ComboCV"));
        combobox2.Active = int.Parse(xmlfile.GetXmlFile("aplicacion","ComboVA"));
        entry_FolderSave.Text = xmlfile.GetXmlFile("aplicacion","DirSave");             
        FileAction.Label = Catalog.GetString("File");
        openAction.Label = Catalog.GetString("Open");      
        EditAction.Label = Catalog.GetString("Edit");
		quitAction.Label = Catalog.GetString("Quit");
		preferenceAction.Label = Catalog.GetString("Preference");
        HelpAction.Label = Catalog.GetString("Help");		
        aboutAction.Label = Catalog.GetString("About");
        lbl1.LabelProp = Catalog.GetString("Convert to:");
        lbl2.LabelProp = Catalog.GetString("Variant:");
        lbl3.LabelProp = Catalog.GetString("Save to:"); 
        lbl4.LabelProp = Catalog.GetString("Basic properties");                 
        lbl5.Markup = "<b>Video</b>";
        lbl6_label = Catalog.GetString("duration:");            
        lbl7_label = Catalog.GetString("dimensions:");
        lbl9_label = Catalog.GetString("video bitrate:");
        lbl8_label = Catalog.GetString("video code:");
        lbl10.Markup = "<b>"+ Catalog.GetString("Sound")+"</b>";
        lbl11_label = Catalog.GetString("audio bitrate:");              
        lbl12_label = Catalog.GetString("audio code:");
        lbl12.LabelProp = lbl12_label;          
        lbl_information.LabelProp = Catalog.GetString("Information");
        lbl_avanced.LabelProp = Catalog.GetString("Avanced");
        lbl_video.LabelProp = Catalog.GetString("Video options");
        lbl_size.LabelProp = Catalog.GetString("Size");
        lbl_audio.LabelProp = Catalog.GetString("Audio opctions");
        lbl_subtitle.LabelProp = Catalog.GetString("Subtitle options");
        lbl_subtitlefile.LabelProp = Catalog.GetString("File");
        GtkLabel10.LabelProp = Catalog.GetString("Conversion details");
        btton_SelectFolderSave.Label = Catalog.GetString("Select");
        ClearPanel();
        CreateTreeView();
    }
    
    private void ClearPanel() {
	    lbl6.LabelProp = lbl6_label;
	    lbl7.LabelProp = lbl7_label;
	    lbl8.LabelProp = lbl8_label;    
	    lbl9.LabelProp = lbl9_label;    
	    lbl11.LabelProp = lbl11_label;
	    lbl12.LabelProp = lbl12_label; 		
		spinbutton1.Value = 0;
        spinbutton1.Sensitive = false;  
        spinbutton2.Value = 0;
        spinbutton2.Sensitive = false;  
        spinbtt_AudioBitrate.Value = 0;
        spinbtt_AudioBitrate.Sensitive = false; 
        spinbtt_VideoBitrate.Value = 0;
        spinbtt_VideoBitrate.Sensitive = false;		
        entrySubtitle.Text = "";
        entrySubtitle.Sensitive = false;
        btton_Subtitle.Sensitive = false;
        btton_SubtitleProperties.Sensitive= false;     
    }
    
    private void Message(MessageType MessageType,ButtonsType ButtonsType,string message)
    {
		MessageDialog md = new MessageDialog (this,DialogFlags.DestroyWithParent,MessageType,ButtonsType,message);
		md.Run ();
		md.Destroy();
    } 
	
	 private void GetInfoVideo(stallion.Video nodo)
    {
		
		lbl6.Text = lbl6_label + nodo.Lengthvideo;
		lbl7.Text = lbl7_label + nodo.Videowidth;	
		lbl7.Text +="x" + nodo.Videoheight; 
		lbl8.Text = lbl8_label + nodo.Videocodec;		
		lbl9.Text = lbl9_label + nodo.Videobitrate;
		lbl11.Text =lbl11_label + nodo.Audiobitrate;
		lbl12.Text =lbl12_label + nodo.Audiocodec;
    }
    
    private string LoadSubtitle(string VideoDirection,int VideoNo)
    {
        string subtitle = null;
        if      (System.IO.File.Exists(System.IO.Path.ChangeExtension(VideoDirection,"srt")))
                subtitle = System.IO.Path.ChangeExtension(VideoDirection,"srt");
        return subtitle;
    }
	
	private void ErrorDataReceived(object o, DataReceivedEventArgs e)
	{ 	
        if (!string.IsNullOrEmpty(e.Data)){			
			if (e.Data.Contains("Couldn't open codec aac"))
				textview3.Buffer.Text +="    ERRORES: "+ e.Data +"See http://stallionv.wordpress.com/ for more details.\n";
			else
           		textview3.Buffer.Text +="    ERRORES: "+ e.Data+"\n";
		}
		
  	} 
    
    private void  BeginProcess(stallion.Video node)
    { 
        string OptionSubtitle = "";
        string OptionConvert = ReadXml("OutParam",node);
        
        if (node.Propiedades.Vbitrate != null)
                OptionConvert = SetParamOptionConv(OptionConvert ,"bitrate=",node.Propiedades.Vbitrate+" ",0);                                
        if (node.Propiedades.Largo != null)
                OptionConvert = SetParamOptionConv(OptionConvert ,"scale=",node.Propiedades.Largo+":",0);     
        if (node.Propiedades.Ancho != null)
                OptionConvert = SetParamOptionConv(OptionConvert ,"scale="+node.Propiedades.Largo+":",node.Propiedades.Ancho+" ",3);
        if (node.Propiedades.Abitrate != null)
                OptionConvert = SetParamOptionConv(OptionConvert ,"cbr=",node.Propiedades.Abitrate+" ",0);            
        if ( node.Subfilename != null) {                    
                OptionSubtitle =  "-ass -ass-color "+ node.Propiedades.Colorfont+"00 -subfont-autoscale 0 -sub '"+ node.Subfilename + "' -font '" + node.Propiedades.Font.Name + "':style='"+node.Propiedades.Font.Style+"' -subfont-text-scale " + node.Propiedades.Font.Size;
                OptionConvert += OptionSubtitle;
        }     
		
        textview3.Buffer.Text += "<Conversión Iniciada>: "+node.Direccion+"\n";
        textview3.Buffer.Text += "<Opciones de Converción>: "+OptionConvert+"\n";
        
        try {
				node.Status = Catalog.GetString("in progress");			
				node.Process = new stallion.Process();
				node.Process.CreateProcessVideo(node, OptionConvert+" '"+node.Direccion+"' -o '"+System.IO.Path.GetFileNameWithoutExtension(node.Direccion)+"'."+ReadXml("OutExt",node), entry_FolderSave.Text);						
				node.Process.ErrorDataReceived += new DataReceivedEventHandler(ErrorDataReceived);
				node.Process.T = new Thread(() => Read(node));
				node.Process.StartProcess();
			
				treeview1.Model.SetValue(node.Iter, 2 , node.Status);	
				treeview1.Model.SetValue(node.Iter, 3, 0);
				treeview1.Model.SetValue(node.Iter, 4, "0");		
				treeview1.Model.SetValue(node.Iter, 5 ,"0");
        } 
		 catch {
			node.Status = Catalog.GetString("error");
         }
    }
	
    private string SetParamOptionConv(string OptionConv, string token, string Param,int Notoken)
    {
        string comp = "";
        string OptionConvNueva = "";
        bool continuar = true;
        
        for (int i=0;i<OptionConv.Length;i++)           
        {       
                comp += OptionConv[i];                  
                
                if (continuar)
                        OptionConvNueva += OptionConv[i];       
                
                if (comp == token) {                    
                        OptionConvNueva += Param;                               
                    continuar = false;                  
                }
        }
         return OptionConvNueva;
    }       
    
    protected string ReadXml(string Option,stallion.Video node)
    {       
	    string convta = null;
	    
	    XmlDocument filexml = new XmlDocument();
	    filexml.Load(XmlOptions);
	    
	    XmlNode nodo;
	    nodo = filexml.DocumentElement.FirstChild;              
	    
	    switch (Option) {
	            
            case "AddCategory":{
				  TreeIter iter;
                  for (int i=0;i<filexml.DocumentElement.ChildNodes.Count;i++)                    
                        {                                                                               
                            int e = -1;                                     
                            combobox1.Model.GetIterFirst (out iter);
                            for (int c=0;c<combobox1.Model.IterNChildren();c++)
                                    {
                            if (combobox1.Model.GetValue (iter, 0).ToString() == nodo.ChildNodes.Item(3).FirstChild.Value )                                         
                                    e = c;  
                                            combobox1.Model.IterNext(ref iter);
                                    }       
                            if (e != -1)
                            combobox1.RemoveText(e);
                            combobox1.AppendText(nodo.ChildNodes.Item(3).FirstChild.Value);
                            nodo = nodo.NextSibling;
                        }
			}
			break;
	
            case "OutParam":{
                    convta = node.Perfil;

                    for (int i=0;i<filexml.DocumentElement.ChildNodes.Count;i++)            
                            {               
                                    if (nodo.ChildNodes.Item(0).FirstChild.Value ==  convta)
                                            return nodo.ChildNodes.Item(1).FirstChild.Value+" ";   
                                    nodo = nodo.NextSibling;
                            }
            }
            break;
                    
            case "OutExt":{
                    convta = node.Perfil;
                    for (int i=0;i<filexml.DocumentElement.ChildNodes.Count;i++) {          
                            if (nodo.ChildNodes.Item(0).FirstChild.Value == convta )
                                    return nodo.ChildNodes.Item(2).FirstChild.Value+" ";     
                            nodo = nodo.NextSibling;
                    }
            }
            break;
                    
            default:{
                   for (int i=0;i<filexml.DocumentElement.ChildNodes.Count;i++)
                        {
                                if (nodo.ChildNodes.Item(3).FirstChild.Value == Option)
                                        combobox2.AppendText(nodo.ChildNodes.Item(0).FirstChild.Value);         
                                nodo = nodo.NextSibling;        
                        }     
			}
        	break;
		}
		return null;
	}
    
	public void CreateTreeView()
    {		
		Gtk.TreeStore treeStore = new Gtk.TreeStore( typeof (string), typeof (string), typeof (string),  typeof (int),  typeof (string), typeof (string));
        treeview1.Model = treeStore;
		
        treeview1.AppendColumn(Catalog.GetString("Name"), new CellRendererText(),"text", 0);   
        treeview1.AppendColumn(Catalog.GetString("Profile"),new CellRendererText(),"text",1);
        treeview1.AppendColumn(Catalog.GetString("Status"),new CellRendererText (),"text",2);
        treeview1.AppendColumn(Catalog.GetString("Progress"),new CellRendererProgress(),"value",3);
        treeview1.AppendColumn(Catalog.GetString("Final Size"),new CellRendererText(),"text",4);
        treeview1.AppendColumn(Catalog.GetString("Time left"),new CellRendererText(),"text",5);
        
        treeview1.Selection.Mode = Gtk.SelectionMode.Multiple;
		
		treeview1.Columns[0].Resizable =  true;
		treeview1.Columns[1].Resizable =  true;
		
		treeview1.Selection.Changed += OnSelectionChanged;
    }
	
	protected void OnSelectionChanged (object o, EventArgs args)
	{
		selectedNodes = SelectedNodes();
    }
 
    
    protected void OnDeleteEvent (object sender, DeleteEventArgs a)
    {
		OnExit();		
		
		/*if (videos.Count != 0 ){		
			MessageDialog md = new MessageDialog (this,DialogFlags.Modal,MessageType.Question,ButtonsType.YesNo,Catalog.GetString("Hay conversiones en progreso, esta seguro que desea salir?"));
			ResponseType result = (ResponseType) md.Run ();	 
			Console.WriteLine(result);
		
			if (result  == ResponseType.Yes){
				for (int i = 0;i < videos.Count;i++)
					if (videos[i].Status == Catalog.GetString("in progress")){					
					videos[i].Process.StopProcess();
				}
				 Application.Quit ();
	        	a.RetVal = false;
			}
		}*/
    }
                    
    protected virtual void OnOpenActionActivated (object sender, System.EventArgs e)
    {       
        if (combobox2.Active != -1) {                   
	    	selectfileandfolder = new stallion.SelectFileAndFolder( Catalog.GetString("Open"),true,xmlfile.GetXmlFile("aplicacion","DirOpen"),this);
	        string[] Files = selectfileandfolder.CreateWindows(FileChooserAction.Open,                                                                           
	                                                                                     selectfileandfolder.addfilter("Todos los Videos","*.mpg","*.avi","*.rm","*.rmvb","*.mp4","*.vob","*.VOB","*.mkv","*.MKV","*.flv","*.FLV","*.wmv","*.WMV","*.DAT"),
	                                                                     		     	 selectfileandfolder.addfilter("Todos los archivos","*.*"),
	                                                                                     selectfileandfolder.addfilter("MKV","*.mkv","*.MKV"),
	                                                                    				 selectfileandfolder.addfilter("WMV","*.wmv","*.WMV"),
	                                                                					 selectfileandfolder.addfilter("FLV","*.flv","*.FLV"),
	                                                                                     selectfileandfolder.addfilter("VOB","*.vob","*.VOB"),
	                                                                                     selectfileandfolder.addfilter("RMVB","*.rm","*.rmvb"),
	                                                                                     selectfileandfolder.addfilter("AVI","*.avi","*.AVI"),
	                                                                                     selectfileandfolder.addfilter("MPG","*.mpg"),
	                                                                                     selectfileandfolder.addfilter("MP4","*.mp4"),
			                                                   							selectfileandfolder.addfilter("DAT","*.DAT")
	                                                                                     );     
	        string videosRepetidos = null;			
	
	        if(Files != null ){
	        	xmlfile.SetXmlFile("aplicacion","DirOpen",System.IO.Path.GetDirectoryName(Files[0]));
	                    
	            for (int i=0;i<Files.Length;i++)
	            {                               
                    stallion.Video tmp = new stallion.Video(Files[i],combobox2.ActiveText,combobox1.ActiveText);                     

                    if ( !videos.Exists(comp => comp.Direccion.Equals(tmp.Direccion)) ){
						videos.Add(tmp); 
						
						System.Threading.Thread t =  new Thread(()=>  tmp.ReadPropertiesVideo() );	
						t.Start();
						
                        if (bool.Parse(xmlfile.GetXmlFile("option","loadsubtitle")))                                                    
                        	tmp.Subfilename = LoadSubtitle(tmp.Direccion,videos.Count-1);		
						
						TreeStore treeStore =  (TreeStore) treeview1.Model;						
						treeStore.AppendValues(System.IO.Path.GetFileName(tmp.Direccion), tmp.Perfil, tmp.Status,0,"-","-");						
                    } else
                     		videosRepetidos +=System.IO.Path.GetFileName(tmp.Direccion)+"\n";
	            }                                
                if (videosRepetidos != null) { 
                        stallion.Dialog1 dialog1 = new stallion.Dialog1(this,videosRepetidos);
                        dialog1.Mostrar();
                }
				AssingIterVideos();
	      	}
	    }
	      else 
	            Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("You must select a format and its variant."));                           
    }               
    
    protected virtual void OnCombobox1Changed (object sender, System.EventArgs e)
    {                       
	    combobox2.Clear();              
	    combobox2.Model = new ListStore(typeof (string));                       
	    CellRendererText textRenderer = new CellRendererText ();                
	    combobox2.PackStart(textRenderer, true);
	    combobox2.AddAttribute (textRenderer, "text", 0);  
		ReadXml(combobox1.ActiveText,null);
    }
	
    
	protected virtual void OnCombobox2Changed (object sender, System.EventArgs e)
	{           
	    xmlfile.SetXmlFile("aplicacion","ComboCV",combobox1.Active.ToString());         
	    xmlfile.SetXmlFile("aplicacion","ComboVA",combobox2.Active.ToString());
		
		if (selectedNodes.Count > 0){
	        for (int i = 0 ; i <  selectedNodes.Count; i++){				
	            stallion.Video node = selectedNodes[i];
	            selectedNodes[i].Category = combobox1.ActiveText;
				selectedNodes[i].Perfil = combobox2.ActiveText;
				treeview1.Model.SetValue(selectedNodes[i].Iter, 1 , node.Perfil);				
				node.Propiedades = new stallion.Propiedades();
	        }
			GetInfoVideo(selectedNodes[0]);		
			OptionsConv(selectedNodes[0]);
			Refresh(selectedNodes[0]);
		}
	}
	
    protected virtual void OnMediaPlayActionActivated (object sender, System.EventArgs e)
    {     
	  	if (videos.Count > 0) {      
	    	if (Directory.Exists(entry_FolderSave.Text)) {
				stallion.Video node;
				
				if (selectedNodes.Count == 0)
					node = videos[0];
				else
					node = selectedNodes[0];
				
				if ((node.Status != Catalog.GetString("paused")) && (node.Status != Catalog.GetString("in progress")))				
					BeginProcess(node);
				else {
						if (node.Status == Catalog.GetString("in progress")){
							node.Process.PauseProcess();
							node.Status =  Catalog.GetString("paused");
						}
					  	else
							if (node.Status == Catalog.GetString("paused")){
								node.Process.ResumeProcess();
								node.Status =  Catalog.GetString("in progress");
							}
						treeview1.Model.SetValue(node.Iter,2,node.Status);						
				}
				Refresh(node);
			}
			  else
						Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("Path not found."));			
		} 
			else
				Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("No file uploade."));
	}
    
    protected virtual void OnMediaStopActionActivated (object sender, System.EventArgs e)
    {
		if (selectedNodes.Count > 0){
			for(int i = 0;i < selectedNodes.Count; i++){				
				stallion.Video node = (stallion.Video) selectedNodes[i];				
				if ((node.Status == Catalog.GetString("in progress")) || (node.Status == Catalog.GetString("paused")) ){				
					node.Process.StopProcess();				
					node.Status = Catalog.GetString("stoped");				
					treeview1.Model.SetValue(node.Iter,2,node.Status);
					treeview1.Model.SetValue(node.Iter,3,0);
					treeview1.Model.SetValue(node.Iter,4,"0");
					treeview1.Model.SetValue(node.Iter,5,"0");				
					Refresh(node);		
				}
			}
		}	
	    else
	    	Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("Not conversion has started."));
    }
    
    protected virtual void OnClearActionActivated (object sender, System.EventArgs e)
    {       
		bool inprogress = false;
		for (int i= 0; i < videos.Count ; i++)
			if (videos[i].Status == Catalog.GetString("in progress")){
				inprogress = true;
				break;				
			}
				
	    if (!inprogress) {		
			TreeStore treeStore =  (TreeStore) treeview1.Model;
			treeStore.Clear();
	        videos.Clear();			
			image3.Clear();
	        ClearPanel();			
			treeview1.ColumnsAutosize();
	    }
	     else
            Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("You must stop the conversion in progress to clean up the data"));
    }
    
    protected virtual void OnBttonSubtitleClicked (object sender, System.EventArgs e)
    {   
		if (selectedNodes .Count == 1){
			stallion.Video node = selectedNodes[0];
	        selectfileandfolder = new stallion.SelectFileAndFolder(Catalog.GetString("Open file"),false,System.IO.Path.GetDirectoryName(node.Direccion),this);
	        string[] file = selectfileandfolder.CreateWindows(FileChooserAction.Open,
															  selectfileandfolder.addfilter("Subtítulos","*.srt","*.SRT"),
			                                                  selectfileandfolder.addfilter("Todos","*.*"));
	        if ( file != null ) {
	            entrySubtitle.Text = file[0];   
	           	node.Subfilename = file[0];                                
	            btton_SubtitleProperties.Sensitive = true;
			}
		}
    }       
	
    protected virtual void OnRemoveActionActivated  (object sender, System.EventArgs e)
    {
	  OnDeleteEvent();
	}
    
    protected virtual void OnBttonSelectFolderSaveClicked (object sender, System.EventArgs e)
    {
	    selectfileandfolder = new stallion.SelectFileAndFolder("Select a directory",false,xmlfile.GetXmlFile("aplicacion","DirSave"),this);
	    string[] folder = selectfileandfolder.CreateWindows(FileChooserAction.SelectFolder);
	    
	    if ( folder != null )
	    {
	        xmlfile.SetXmlFile("aplicacion","DirSave",folder[0]);           
	        entry_FolderSave.Text = xmlfile.GetXmlFile("aplicacion","DirSave");                             
	    }
    }
	
    protected void OnEntrySubtitleFocusOutEvent (object o, Gtk.FocusOutEventArgs args)
    {
	    if ( (entrySubtitle.Text != "") & (!File.Exists(entrySubtitle.Text)) ) {                    
	        Message(MessageType.Error,ButtonsType.Close,"Not found the file specified");                                               
	        entrySubtitle.Text="";
	    }       
    }
    
    private Gdk.Color HexToColor(string hexColor)
	{
        if (hexColor.IndexOf('#') != -1)
            hexColor = hexColor.Replace("#", "");

        int red = 0;
        int green = 0;
        int blue = 0;

        if (hexColor.Length == 6)
        {
            red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
        }

        return new  Gdk.Color(byte.Parse(red.ToString()), byte.Parse(green.ToString()), byte.Parse(blue.ToString()));
	}
    
    private void OptionsConv (stallion.Video node)
    {
	    string OptionPanelElement = null;
	    
	    if ( node.Propiedades.Largo == null ) {    
	            OptionPanelElement = node.GetParamOptionConv(ReadXml("OutParam",node),"scale=");
	            if      (OptionPanelElement != null)
	                    spinbutton1.Value = double.Parse(OptionPanelElement);
	            else
	                    spinbutton1.Value = 0;
	    }
	     else
	            spinbutton1.Value = double.Parse(node.Propiedades.Largo);
	
	    if ( node.Propiedades.Ancho == null ) {
	            OptionPanelElement =  node.GetParamOptionConv(ReadXml("OutParam",node),"scale="+ node.GetParamOptionConv(ReadXml("OutParam",node),"scale=")+':');
	            if      (OptionPanelElement != null)
	                    spinbutton2.Value = double.Parse(OptionPanelElement);
	            else
	                    spinbutton2.Value = 0;
	    }
	     else
	            spinbutton2.Value = double.Parse(node.Propiedades.Ancho);
	    
	    if ( node.Propiedades.Vbitrate == null) {
	            OptionPanelElement =  node.GetParamOptionConv(ReadXml("OutParam",node),"bitrate=","vbitrate=");
	            if ( OptionPanelElement != null)
	                    spinbtt_VideoBitrate.Value = double.Parse(OptionPanelElement);
	            else
	                    spinbtt_VideoBitrate.Value = 0;
	    }
	     else
	            spinbtt_VideoBitrate.Value = double.Parse(node.Propiedades.Vbitrate.ToString());   
	    
	    if ( node.Propiedades.Abitrate == null ) {
	            OptionPanelElement =  node.GetParamOptionConv(ReadXml("OutParam",node),"cbr=","abitrate=");
	            if ( OptionPanelElement != null)
	                    spinbtt_AudioBitrate.Value = double.Parse(OptionPanelElement);
	            else
	                    spinbtt_AudioBitrate.Value = 0;
	    } 
	     else spinbtt_AudioBitrate.Value = double.Parse(node.Propiedades.Abitrate.ToString());             
	    
	    if (node.Subfilename != null){                     
	            entrySubtitle.Text=node.Subfilename;
	    }
	    else {
	            entrySubtitle.Text = "";
	    }
	    
	    if (spinbtt_VideoBitrate.Value == 0) spinbtt_VideoBitrate.Sensitive = false;    
	    else spinbtt_VideoBitrate.Sensitive = true;
	    
	    if (spinbtt_AudioBitrate.Value == 0) spinbtt_AudioBitrate.Sensitive = false;
	    else spinbtt_AudioBitrate.Sensitive = true;
	    
	    if (spinbutton1.Value == 0)     spinbutton1.Sensitive = false;
	    else spinbutton1.Sensitive = true;
	    
	    if (spinbutton2.Value == 0) spinbutton2.Sensitive = false;
	    else spinbutton2.Sensitive = true;
	    
	    if (node.Subfilename == null )
	            btton_SubtitleProperties.Sensitive = false;
	    else    
	            btton_SubtitleProperties.Sensitive = true;
	    
	    btton_Subtitle.Sensitive = true;
	    entrySubtitle.Sensitive = true;
    }

    protected void OnPreferenceActionActivated (object sender, System.EventArgs e)
    {
            stallion.Preference preference = new stallion.Preference(this);
            preference.ShowAll();
    }

    protected void OnAboutActionActivated (object sender, System.EventArgs e)
    {
        stallion.About about = new stallion.About();
        about.CreateDialog();
    }

    protected void OnBttonSubtitlePropertiesClicked (object sender, System.EventArgs e)
    {
		stallion.Video node = selectedNodes[0];
		
        FontButton fontButton = new FontButton(node.Propiedades.Font.Name +" "+node.Propiedades.Font.Style+" "+node.Propiedades.Font.Size);
        ColorButton colorButton = new ColorButton(HexToColor(node.Propiedades.Colorfont));		
		
        stallion.Dialog2 dialog2 = new stallion.Dialog2(this,selectedNodes.ToArray(),fontButton,colorButton);
        dialog2.Mostrar();
    }
	
	public  void OnSetValueVideoProperties(stallion.Propiedades propiedades)
	{	
		for (int i = 0 ; i <  selectedNodes.Count; i++){
                    stallion.Video node = selectedNodes[i];
					if (propiedades.Ancho != null)
						node.Propiedades.Ancho = propiedades.Ancho;
					if (propiedades.Largo != null)
						node.Propiedades.Largo = propiedades.Largo;
					if (propiedades.Vbitrate != null)
						node.Propiedades.Vbitrate = propiedades.Vbitrate;
					if (propiedades.Abitrate != null)
						node.Propiedades.Abitrate = propiedades.Abitrate;
		}
	}
	
    protected void OnSpinbutton1ValueChanged (object sender, System.EventArgs e)
    {
		OnSetValueVideoProperties( new stallion.Propiedades() {Largo=spinbutton1.Text});
    }

    protected void OnSpinbutton2ValueChanged (object sender, System.EventArgs e)
    {
		OnSetValueVideoProperties( new stallion.Propiedades() {Ancho = spinbutton2.Text});
    }

    protected void OnSpinbttVideoBitrateValueChanged (object sender, System.EventArgs e)
    {
		OnSetValueVideoProperties( new stallion.Propiedades() {Vbitrate = spinbtt_VideoBitrate.Text});
    }

    protected void OnSpinbttAudioBitrateValueChanged (object sender, System.EventArgs e)
    {		
		OnSetValueVideoProperties( new stallion.Propiedades() {Abitrate = spinbtt_AudioBitrate.Text});
    }
	
	private int GetItemCombobox(Gtk.ComboBox comboBox, string activeText){		
		Gtk.TreeIter iter;		
		comboBox.Model.GetIterFirst(out iter);		
		for (int i = 0; i<  comboBox.Model.IterNChildren(); i++ ){	
			if ( comboBox.Model.GetValue(iter,0).Equals(activeText) )	
				return i;
			comboBox.Model.IterNext(ref iter);
		}
		return -1;
	}	
	
	protected void OnTreeview1CursorChanged (object sender, System.EventArgs e)
	{		
		if (selectedNodes.Count > 0){			
			stallion.Video node = selectedNodes[0];	
			Gtk.TreeIter iter;
			
			if ( combobox1.ActiveText != node.Category){				
				combobox1.Model.IterNthChild(out iter, GetItemCombobox(combobox1,node.Category) );
				combobox1.SetActiveIter (iter);
			}
			
			if ( (combobox2.ActiveText != node.Perfil))	{
				combobox2.Model.IterNthChild(out iter, GetItemCombobox(combobox2,node.Perfil) );
				combobox2.SetActiveIter (iter);
			}
			
			Refresh(node);
		}
	}
	
	protected void OnTreeview1ButtonReleaseEvent (object o, Gtk.ButtonReleaseEventArgs args)
	{
		/*if ( args.Event.Button == 3)
		{			
	        Menu popupMenu = new Menu();
	        ImageMenuItem menuItem1 = new ImageMenuItem(Catalog.GetString("select to all"));      
	        ImageMenuItem menuItem2 = new ImageMenuItem(Catalog.GetString("unselected"));           
	        ImageMenuItem menuItem3 = new ImageMenuItem(Catalog.GetString("remove"));
			ImageMenuItem menuItem4 = new ImageMenuItem(Catalog.GetString("clear"));
	        
	        popupMenu.Add(menuItem1);           
	        popupMenu.Add(menuItem2);   
	        popupMenu.Add(menuItem3);     
			popupMenu.Add(menuItem4);
			
	        popupMenu.ShowAll();
	        popupMenu.Popup();      
		}*/
	}
	
	private void Refresh(stallion.Video node ){
		if (selectedNodes.Count == 0)			
			treeview1.Selection.SelectIter(node.Iter);
		
		if (node.Status == Catalog.GetString("in progress")){
			mediaPlayAction.StockId = Stock.MediaPause;
			mediaStopAction.Sensitive = true;			
			spinbtt_VideoBitrate.Sensitive = false;
	    	spinbtt_AudioBitrate.Sensitive = false;
	   		spinbutton1.Sensitive = false;
	  		spinbutton2.Sensitive = false;	    
	        btton_SubtitleProperties.Sensitive = false;
			btton_Subtitle.Sensitive = false;
			entrySubtitle.Sensitive = false;
		}
		else {
			mediaPlayAction.StockId =Stock.MediaPlay;
			mediaStopAction.Sensitive = false;			
		}
		
		if (treeview1.Selection.IterIsSelected(node.Iter)){
			GetInfoVideo(node);		
			OptionsConv(node);
		}
	}
	
	private string GetParamOutProcess(char paramt1, char paramt2, string cadena, int espacio)
    {
	    string resultado = "";
	
	    for (int i=0;i<cadena.Length-espacio;i++) 
	     if ( (cadena[i] == paramt1) & (cadena[i+espacio] == paramt2) )
	            {
	                    for (int j=i+1;j<i+espacio;j++)                         
	                    resultado += cadena[j];
	                    break;
	            } 
		
		if (resultado.Equals(""))
	    	return "0";
		else
	    	return resultado;
	}	
	
	private Gtk.TreeIter TreeIter (int id)
	{
                TreeIter iter;
                treeview1.Model.GetIterFromString(out iter,(id-1).ToString()); 
                return iter;
    }
	
	public void Read(stallion.Video node)
	{
		string line = null;
        string lefttime = null;
		int p = 0;
				
		node.Process.Start();	
		Thread.Sleep(3);
		node.Process.BeginErrorReadLine();
		
		Gtk.TreeIter iter = node.Iter;
		
        while (!node.Process.StandardOutput.EndOfStream)  {				
			
			line = node.Process.StandardOutput.ReadLine();			
			
			p = int.Parse(GetParamOutProcess('(','%',line,3));
			
			if ( (int) treeview1.Model.GetValue(iter,3) < p ) {
				try {						
						lefttime = GetParamOutProcess(':','n',line,7).Replace(" ","");				
			 			if (int.Parse(lefttime.Remove(lefttime.Length-2)) != 0)
			            	lefttime = lefttime+"n";
						else
							if ((int.Parse(lefttime.Remove(lefttime.Length-2)) == 0))
								lefttime = Catalog.GetString("less than one minute");
				} catch {};
				
				string sizefinal  = GetParamOutProcess('n','A',line,9).Replace(" ","");	
				
				treeview1.Model.SetValue(iter,3,p);
				treeview1.Model.SetValue(iter,4,sizefinal);
				treeview1.Model.SetValue(iter,5,lefttime);
				
				treeview1.HasFocus = true;
			}
		}
		
		node.Process.WaitForExit();
		
		if (node.Process.ExitCode !=  0){
			node.Status = "error";
			treeview1.Model.SetValue(iter,2,node.Status);
		}
		
		ExitedProcess(node);
    }
	
	public void ExitedProcess(stallion.Video node)   
    {	
		
		if (node.Status != "error"){
			node.Status = Catalog.GetString("complete");
			TreeIter iter =  node.Iter;		
			treeview1.Model.SetValue(iter,2,node.Status);
			treeview1.Model.SetValue(iter,3,100);
			treeview1.Model.SetValue(iter,5,"-");
		}
		
		
		if (bool.Parse(xmlfile.GetXmlFile("option","infoend"))){
			Notification mensage = new Notification();
			mensage.Icon = new Pixbuf(stallion.MainClass.GetExecutablePath()+"/icons/48x48/stallion.png");
			mensage.Summary = Catalog.GetString("Conversion completed");
		
			if (node.Status != "error")
		        mensage.Body = Catalog.GetString("The conversion of the video '")+System.IO.Path.GetFileName(node.Direccion)+Catalog.GetString("' was compled sucessfully.");	
		    else
				mensage.Body = Catalog.GetString("The conversion of the video '")+System.IO.Path.GetFileName(node.Direccion)+Catalog.GetString("' was compled  with errors.");	
		
			Thread  mesg = new Thread(() => mensage.Show());
			mesg.Start();
		}
		
		int index = -1;
		
		for (int j = 0 ; j < videos.Count; j++){
			if ( (videos[j].Status != Catalog.GetString("complete")) && (videos[j].Status != Catalog.GetString("in progress")) && (videos[j].Status !="error") ){
				index = j;
				break;
			}				
		}
		
        if (index != -1)
			BeginProcess(videos[index]);		
		else
            if ( bool.Parse(xmlfile.GetXmlFile("option","poweroff")) )  {
	            stallion.Process poweroff = new stallion.Process();
	            poweroff.CreateProcess("gnome-session-save", "--shutdown-dialog",HomeDir);
	            poweroff.StartProcess();
			}
			
		if  (selectedNodes.Count > 0)
			Refresh(selectedNodes[0]);
    }
	
	private void AssingIterVideos ()
	{
		Gtk.TreeIter iter;
		treeview1.Model.GetIterFirst(out iter);		
		for(int i=0; i < videos.Count; i++){				
			videos[i].Iter = iter;
			treeview1.Model.IterNext(ref iter);
		}
	}
	
	private List<stallion.Video> SelectedNodes ()
	{
		AssingIterVideos();
		List<stallion.Video> nodes = new List<stallion.Video>();
		
		for(int i=0; i < videos.Count; i++){				
			if (treeview1.Selection.IterIsSelected(videos[i].Iter)) {
				nodes.Add(videos[i]);
			}
		}
		return nodes;
	}
	
	public void OnExit(){
		for (int i = 0;i < videos.Count;i++)
				if (videos[i].Status == Catalog.GetString("in progress")){					
				videos[i].Process.StopProcess();
			}
        Application.Quit ();
		this.Destroy();
		
	}

	protected void OnQuitAction1Activated (object sender, System.EventArgs e)
	{
		OnExit();
	}
	
	private void OnDeleteEvent (){
		
		if (selectedNodes.Count > 0){
			
			TreeStore treeStore =  (TreeStore) treeview1.Model;
			stallion.Video node;	
			bool flag = false;
		
			for (int i = 0;  i < selectedNodes.Count+1; i++){
				
				node = selectedNodes[selectedNodes.Count-1];			
					
				if (selectedNodes[selectedNodes.Count-1].Status != Catalog.GetString("in progress")){						
					TreeIter iter = node.Iter;
					treeStore.Remove(ref  iter);
					videos.Remove(node);			
				}
				 else 
					flag = true;
			}
				
			if (flag){
				Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("Can not delete some items, conversion in progress."));			
			}
				else{
				ClearPanel();
				image3.Clear();
			}
		} 
		  else
            Message(MessageType.Error,ButtonsType.Close,Catalog.GetString("Not selected any element"));
	}
	
	protected void OnTreeview1KeyPressEvent (object o, Gtk.KeyPressEventArgs args)
	{
		if (  args.Event.Key  ==  Gdk. Key.Delete ){
			
			if (xmlfile.GetXmlFile("option","notShowDeleteDialog") == "True") {
				MessageDialog md = new MessageDialog (this,DialogFlags.Modal,MessageType.Info,ButtonsType.YesNo,Catalog.GetString("Are you sure to delete this file(s)."));
				CheckButton checkButton = new CheckButton(Catalog.GetString("Don't show this message again."));
				md.VBox.Add(checkButton);
				md.ShowAll();
				if ( (ResponseType) md.Run() == ResponseType.Yes)
					OnDeleteEvent();
				
				if (checkButton.Active)
					xmlfile.SetXmlFile("option","notShowDeleteDialog","False");				
				
				md.Destroy();				
			}
			else {
				OnDeleteEvent();
			}
		}		    
	}

	protected void OnButton19Clicked (object sender, System.EventArgs e)
	{
		System.Diagnostics.Process.Start(entry_FolderSave.Text);	
	}

	protected void OnHelpActionActivated (object sender, System.EventArgs e)
	{
		System.Diagnostics.Process.Start("http://stallionv.wordpress.com/help");
	}
}