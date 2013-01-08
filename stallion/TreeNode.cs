using System;

namespace stallion
{
	public class TreeNode : Gtk.TreeNode
	{		
		private string name;
		private string finalsize;
		private string letftime;
		private string  status;
		private int progress;
		private string  perfil;
		
		private Propiedades2 propiedades;
		private string direccion;
		private string subfilename;
	
        public TreeNode (string direccion,string perfil)
		{
			this.direccion = direccion;
        	this.name = System.IO.Path.GetFileName(direccion);
			this.perfil = perfil;
			this.finalsize = "0";
			this.letftime = "0";
			this.progress = 0;
			this.status = Mono.Unix.Catalog.GetString("waiting");			
			propiedades = new Propiedades2();
        }
		
		[Gtk.TreeNodeValue (Column=0)]	
		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}
		
		[Gtk.TreeNodeValue (Column=1)]
		public string Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		} 
		
		[Gtk.TreeNodeValue (Column=2)]
		public string Perfil {
			get {
				return this.perfil;
			}
			set {
				perfil = value;
			}
		}
		
		[Gtk.TreeNodeValue (Column=3)]
		public int Progress {
			get {
				return this.progress;
			}
			set {
				progress = value;
			}
		}
		
		[Gtk.TreeNodeValue (Column=4)]	
		public string FinalSize {
			get {
				return this.finalsize;
			}
			set {
				finalsize = value;
			}
		}
			
		[Gtk.TreeNodeValue (Column=5)]
		public string LetfTime {
			get {
				return this.letftime;
			}
			set {
				letftime = value;
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
	
	
		public stallion.Propiedades2 Propiedades {
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
	}
	
	public class Propiedades2
	{
		private string substylefont = "";
  	 	private string subsizefont = "10";
		private string subfont = "Sans";
		private string subcolorfont = "FFFFFF";
		private string largo= null;
	 	private string nivelvolumen = null;
  	 	private string vbitrate = null;		
 	 	private string abitrate = null;
 	 	private string ancho = null;
		
		public string Subfontstyle {
			get { 
				return this.substylefont; 
			}
			set { 
				substylefont = value;	
			}
		}
		
		public string Subsize {
			get {
				return this.subsizefont;
			}
			set {
				subsizefont = value;
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
		
		public string Subfont {
			get {
				return this.subfont;
			}
			set {
				subfont = value;
			}
		}	
			
		public string Colorfont {
			get {
				return this.subcolorfont;
			}
			set {
				subcolorfont = value;
			}
		}	
	}
}

