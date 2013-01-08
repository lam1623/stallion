using System;
using Gtk;
using Mono.Unix;

namespace stallion
{
	public partial class Preference : Gtk.Dialog
	{
		private stallion.xmlfile xmlfile = new stallion.xmlfile();
		private MainWindow mainWindow;
		
		public Preference (MainWindow mainWindow): base (Catalog.GetString("Preference"),mainWindow,Gtk.DialogFlags.DestroyWithParent)
		{
			Modal = true;
			this.mainWindow = mainWindow;
			this.Build ();
			
			
			checkbutton1.Active = bool.Parse(xmlfile.GetXmlFile("option","loadsubtitle"));
			checkbutton3.Active = bool.Parse(xmlfile.GetXmlFile("option","infoend"));
			checkbutton4.Active = bool.Parse(xmlfile.GetXmlFile("option","poweroff"));
			
			entry_FileXmlOptions.Text = xmlfile.GetXmlFile("unix","PresetXml");
			
			if ( xmlfile.GetXmlFile("option","notShowDeleteDialog") != "")
				checkbutton5.Active = bool.Parse(xmlfile.GetXmlFile("option","notShowDeleteDialog"));	
		}

		protected void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			if (!System.IO.File.Exists(entry_FileXmlOptions.Text)) {
				string mensage = Catalog.GetString("The file path is invalid.");
				MessageDialog md = new MessageDialog (this,DialogFlags.DestroyWithParent,MessageType.Error,ButtonsType.Ok,mensage);
       			md.Run ();
       			md.Destroy();	
			} 
			else {			
					xmlfile.SetXmlFile("option","loadsubtitle",checkbutton1.Active.ToString());
					xmlfile.SetXmlFile("option","infoend",checkbutton3.Active.ToString());
					xmlfile.SetXmlFile("option","poweroff",checkbutton4.Active.ToString());			
					xmlfile.SetXmlFile("unix","PresetXml",entry_FileXmlOptions.Text);
					xmlfile.SetXmlFile("option","notShowDeleteDialog",checkbutton5.Active.ToString());
					Destroy();	
			}
		}		

		protected void OnBttonSelectXmlOptionsClicked (object sender, System.EventArgs e)
		{
			stallion.SelectFileAndFolder selectFileAndFolder = new stallion.SelectFileAndFolder(Catalog.GetString("Open file"),false,MainClass.GetExecutablePath(),mainWindow);
			string[] file = selectFileAndFolder.CreateWindows(FileChooserAction.Open,selectFileAndFolder.addfilter("Xml","*.xml"));
			if (file != null)
				entry_FileXmlOptions.Text = file[0];
		}
		
		protected void OnButtonCancelClicked (object sender, System.EventArgs e)
		{
			Destroy();
		}
	}
}


