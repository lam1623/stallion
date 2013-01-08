using System;
using Gtk;
using Gdk;

namespace stallion
{	
	class MainClass
	{
		private static string ExecutablePath = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.ToString()).Remove(0,5));
		
		public static string GetExecutablePath() {
			return ExecutablePath;
		}		
				
		public static void Main (string[] args)
		{				
			Application.Init ();		
			MainWindow win = new MainWindow ();			
			win.DeleteEvent += delegate { Application.Quit(); };			
			//win.tr = new StatusIcon(new Pixbuf (GetExecutablePath()+"/stallion.ico"));
			//win.Icon = new Pixbuf (GetExecutablePath()+"/stallion.ico");
			//win.trayIco.Visible = true;		
			//win.trayIcon.Activate += delegate { win.Visible = !win.Visible; };							
			win.Show ();
			Application.Run ();
		}
	}
}