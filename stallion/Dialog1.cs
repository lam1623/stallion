using System;
using Mono.Unix;

namespace stallion
{
	public partial class Dialog1 : Gtk.Dialog
	{
		private int heigth;
		private string list;
		
		public Dialog1 (MainWindow mainWindow,String list): base (Catalog.GetString("Information"),mainWindow,Gtk.DialogFlags.DestroyWithParent)
		{
			Modal = true;
			this.list = list;				
		}
		
		public void Mostrar(){
			this.Build ();	
			textview1.Buffer. Text = list;
			heigth = DefaultHeight;
		}
		
		protected void OnExpander1Activated (object sender, System.EventArgs e)
		{
			this.Resize(this.DefaultWidth,heigth+textview1.Buffer.LineCount*10);
		}

		protected void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			Destroy();
		}

		protected void OnExpander1ExposeEvent (object o, Gtk.ExposeEventArgs args)
		{
			this.Resize(this.DefaultWidth,heigth);
		}
	}
}

