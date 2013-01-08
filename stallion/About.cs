using System;
using Gdk;
using System.Reflection;

namespace stallion
{
	public class About
	{	
		public About ()
		{	
		}
		
		public void CreateDialog()
		{
			Gtk.AboutDialog aboutDialog = new Gtk.AboutDialog();
			
			System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
		
			aboutDialog.Modal = true;
			
			aboutDialog.Logo = new Gdk.Pixbuf(stallion.MainClass.GetExecutablePath()+"/stallion.ico");
			
			aboutDialog.ProgramName = (asm.GetCustomAttributes (
				typeof (AssemblyTitleAttribute), false) [0]
				as AssemblyTitleAttribute).Title;
			
			aboutDialog.Version = asm.GetName ().Version.ToString().Remove(6);
			
			aboutDialog.Copyright = (asm.GetCustomAttributes (
				typeof (AssemblyCopyrightAttribute), false) [0]
				as AssemblyCopyrightAttribute).Copyright;
			
			aboutDialog.Comments = (asm.GetCustomAttributes (
				typeof (AssemblyDescriptionAttribute), false) [0]
				as AssemblyDescriptionAttribute).Description;
			
			aboutDialog.License = license;			
			aboutDialog.Authors = authors;
			aboutDialog.Website = "http://stallionv.wordpress.com/";
			
            aboutDialog.Run ();
            aboutDialog.Destroy ();
		}
		
		
	private static string [] authors = new string [] {
		"Lino L. Alfonso Morales <lino@lt.deosft.cu>"
	};

		static private string license =@"Se autoriza, de forma gratuita, a cualquier persona que obtenga
una copia de este software y archivos de documentación asociados (el
Software), para trabajar con el Software sin restricciones, permitirá a las personas a quienes se suministra el software para hacerlo, con sujeción a
las siguientes condiciones:
El aviso de copyright anterior y este aviso de permiso se
en todas las copias o partes sustanciales del Software.

EL SOFTWARE SE ENTREGA TAL CUAL, SIN GARANTÍA DE NINGÚN TIPO,
EXPRESAS O IMPLÍCITAS, LIMITADAS A LAS GARANTÍAS DE
COMERCIALIZACIÓN, APTITUD PARA UN PROPÓSITO PARTICULAR Y
INFRACCIÓN. EN NINGÚN CASO LOS AUTORES O TITULARES DEL COPYRIGHT SERÁN
RESPONSABLE DE CUALQUIER RECLAMACIÓN, DAÑO U OTRA RESPONSABILIDAD, YA SEA EN UNA ACCIÓN
DE CONTRATO, AGRAVIO O CUALQUIER OTRA FORMA, QUE SURJAN DE O EN CONEXION
CON EL SOFTWARE O EL USO U OTROS TRATOS EN EL SOFTWARE.";
	};
}

