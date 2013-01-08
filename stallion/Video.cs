using System;
using System.Collections.Generic;

namespace stallion
{
	public class Video : Gtk.TreeNode
	{
		private string direccion;
  	 	private string state;
	 	private string convertirA;
	 	private int tiemprestant;
  	 	private string subfilename;
		private Propiedades propiedades;
		
		public Video(string direccion)
		{
			this.direccion = direccion;
			propiedades = new Propiedades();
		}
		
		public Propiedades Propiedades {
			get {
				return this.propiedades;
			}
			set {
				propiedades = value;
			}
		}
		
		public string ConvertirA {
			get {
				return this.convertirA;
			}
			set {
				convertirA = value;
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

		public string Estado {
			get {
				return this.state;
			}
			set {
				state = value;
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
		
		public int Tiemprestant {
			get {
				return this.tiemprestant;
			}
			set {
				tiemprestant = value;
			}
		}
	}
	
	public class Propiedades
	{
		private string substylefont = "";
  	 	private string subsizefont = "";
		private string subfont = "";
		private string subcolorfont = null;
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

