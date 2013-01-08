using System;

namespace stallion
{
	
	public class Video : Gtk.TreeNode
	{
		private string  status;
		private string  category;
		private string  perfil;
		private Process process;
		
		private Propiedades propiedades;
		private string direccion;
		private string subfilename;
		
		private string lengthvideo;
		private string videowidth;
		private string videoheight;
		private string videobitrate;
		private string videocodec;
		private string audiobitrate;
		private string audiocodec;
		
		private Gtk.TreeIter iter;
	
		public Video ()
		{
		}
		
        public Video (string direccion,string perfil,string category)
		{
			this.direccion = direccion;
			this.perfil = perfil;	
			this.category = category;
			this.status = Mono.Unix.Catalog.GetString("waiting");		
			propiedades = new Propiedades();
        }
		
		public string Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		} 

		public string Category {
			get {
				return this.category;
			}
			set {
				category = value;
			}
		}		  
		
		public string Perfil {
			get {
				return this.perfil;
			}
			set {
				perfil = value;
			}
		}	  
		
		public stallion.Process Process {
			get {
				return this.process;
			}
			set {
				process = value;
			}
		}	
		
		public string Direccion {
			get {
				return this.direccion;
			}
			set {
				direccion = value;
			}
		}
		
		public stallion.Propiedades Propiedades {
			get {
				return this.propiedades;
			}
			set {
				propiedades = value;
			}
		}
	
		public string Subfilename {
			get {
				return this.subfilename;
			}
			set {
				subfilename = value;
			}
		}

		public Gtk.TreeIter Iter {
			get {
				return this.iter;
			}
			set {
				iter = value;
			}
		}

		public string Audiobitrate {
			get {
				return this.audiobitrate;
			}
			set {
				audiobitrate = value;
			}
		}

		public string Audiocodec {
			get {
				return this.audiocodec;
			}
			set {
				audiocodec = value;
			}
		}

		public string Lengthvideo {
			get {
				return this.lengthvideo;
			}
			set {
				lengthvideo = value;
			}
		}

		public string Videobitrate {
			get {
				return this.videobitrate;
			}
			set {
				videobitrate = value;
			}
		}

		public string Videocodec {
			get {
				return this.videocodec;
			}
			set {
				videocodec = value;
			}
		}

		public string Videoheight {
			get {
				return this.videoheight;
			}
			set {
				videoheight = value;
			}
		}

		public string Videowidth {
			get {
				return this.videowidth;
			}
			set {
				videowidth = value;
			}
		}		
		
		public string GetParamOptionConv (string OptionConv, params string[] Param)
    	{
	        string OutParam = null;
	        string comp = null;             
	
	        for (int k=0;k<Param.Length;k++)
	        {
	                if (OutParam==null)
	                for (int i=0;i<OptionConv.Length;i++)
	                {
	                        comp += OptionConv[i];                  
	                        
	                        if (comp == Param[k])                   
	                                for (int j=i+1; j<OptionConv.Length; j++)
	                                {
	                                        if ((OptionConv[j] == ' ') || (OptionConv[j] == ':') ) break;                                                                           
	                                        OutParam += OptionConv[j];                                                      
	                                }       
	                        
	                        if ( (OptionConv[i] == ' ') || (OptionConv[i] == ':') ) comp = "";      
	                }
	        }
	        return OutParam;
   		}               
		
		public void ReadPropertiesVideo(){
			
			string result = null;
			string line = "";
			videowidth  = "";
			lengthvideo = null;
			videowidth  = "";
			videoheight = "";
			videobitrate= "";
			videocodec = "";
			videobitrate= "";
			audiobitrate= "";
			audiocodec = "";
			
			stallion.Process videoInfo = new stallion.Process();			
			videoInfo.CreateProcess("/usr/bin/mplayer",
		                      				 "-vo null -ao null -frames 0 -identify -really-quiet '" +direccion+"'",
		                     				 "/tmp");
			videoInfo.Start();
			
			while (!videoInfo.StandardOutput.EndOfStream){
				
				line = videoInfo.StandardOutput.ReadLine();
				
				result = GetParamOptionConv(line,"ID_LENGTH=");
				if (result != null)
	      			lengthvideo = result; 
			
	            result = GetParamOptionConv(line,"ID_VIDEO_WIDTH=");		
	            if (result != null)
					videowidth = result ;
				
	            result = GetParamOptionConv(line,"ID_VIDEO_HEIGHT="); 
	            if ( result!= null )
					videoheight = result;      
				
	            result = GetParamOptionConv(line,"ID_AUDIO_BITRATE=");                  
	            if (result != null)
	                    audiobitrate = (int.Parse(result) / 1000).ToString();
				
	            result = GetParamOptionConv(line,"ID_VIDEO_BITRATE=");
	            if (result != null )
	                 videobitrate = (int.Parse(result)/1000).ToString();   
				
	            result = GetParamOptionConv(line,"ID_VIDEO_CODEC=");
	            if (result != null)
	                     videocodec = result.Remove(0,2);
				
	            result = GetParamOptionConv(line,"ID_AUDIO_CODEC=");
				
	            if (result != null )
	            if (result[0] == 'f')
	                   audiocodec = result.Remove(0,1);
	             else
	                    audiocodec = result;
			}
			
			videoInfo.WaitForExit();
			
            if ( lengthvideo != null )
	            for (int i=0;i<lengthvideo.Length;i++)
					if (lengthvideo[i]  !=  '.' )
						result += lengthvideo[i];
					else
	                	result += ","; 
			lengthvideo = result + " seg";
		}
	}
	
	public class Propiedades
	{		
		private Font font;
		private string colorfont = "FFFFFF";
		private string largo= null;
	 	private string nivelvolumen = null;
  	 	private string vbitrate = null;		
 	 	private string abitrate = null;
 	 	private string ancho = null;
		
		public Propiedades()
		{
			font = new Font();			
		}	

		public stallion.Font Font {
			get {
				return this.font;
			}
			set {
				font = value;
			}
		}	
		
		public String Vbitrate {
			get {
				return this.vbitrate;
			}
			set {
				vbitrate = value;
			}
		}
				
		public String Abitrate {
			get {
				return this.abitrate;
			}
			set {
				abitrate = value;
			}
		}
	
		public string Ancho {
			get {
				return this.ancho;
			}
			set {
				ancho = value;
			}
		}
			
		public string Largo {
			get {
				return this.largo;
			}
			set {
				largo = value;
			}
		}
	
		public string Nivelvolumen {
			get {
				return this.nivelvolumen;
			}
			set {
				nivelvolumen = value;
			}
		}
		
		public string Colorfont {
			get {
				return this.colorfont;
			}
			set {
				colorfont = value;
			}
		}	
	}
	
	public class Font
	{
		private string style = "";
		private string size = "9";
		private string name = "Sans";
		
		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}
	
		public string Size {
			get {
				return this.size;
			}
			set {
				size = value;
			}
		}
	
		public string Style {
			get {
				return this.style;
			}
			set {
				style = value;
			}
		}
	}
}

