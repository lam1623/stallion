using System;
using Mono.Unix;
using Gtk;

namespace stallion
{
	public partial class Dialog2 : Gtk.Dialog
	{
		private stallion.Video[] nodes;
		private FontButton fontButton;
		private ColorButton colorButton;
			
		public Dialog2 (MainWindow mainWindow,stallion.Video[] nodes,FontButton fontButton, ColorButton colorButton): base (Catalog.GetString("Options"),mainWindow,Gtk.DialogFlags.DestroyWithParent)
		{
			Modal = true;
			this.nodes = nodes;
			this.fontButton = fontButton;
			this.colorButton = colorButton;
		}
		
		public void Mostrar () {			
			this.Build ();
			fontbutton1.FontName = fontButton.FontName;
			colorbutton1.Color = colorButton.Color;
		}

		protected void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			string colorRgb = String.Format ("{0:X2}{1:X2}{2:X2}", colorbutton1.Color.Red/256 ,colorbutton1.Color.Green/256, colorbutton1.Color.Blue/256);
			stallion.Font font = GetSubtitleFont();
			
			for (int i = 0; i < nodes.Length; i++){
				stallion.Video node = (stallion.Video) nodes[i];
				node.Propiedades.Colorfont = colorRgb;
				node.Propiedades.Font = font;
			}
			Destroy();
		}
		
		private stallion.Font GetSubtitleFont()
		{
			string validarfont = "";
			stallion.Font font = new stallion.Font();
			
			for (int i=0; i < fontbutton1.FontName.Length; i++)
			{			
				font.Size += fontbutton1.FontName[i];
				if (fontbutton1.FontName[i] == ' ')	
					font.Size = "";
			}			
			
			for (int i=0; i < fontbutton1.PangoContext.Families.Length ; i++)
			{
				validarfont = "";			
				for (int j=0; j < fontbutton1.FontName.Length ; j++)			
				{		
					validarfont += fontbutton1.FontName[j];				
					if ( fontButton.PangoContext.Families[i].Name == validarfont )
					{
						font.Name = validarfont;
						for (int k=j+2; k < fontbutton1.FontName.Length-3; k++)						
							font.Style += fontbutton1.FontName[k];
					}
				}
			}	
			return font;
		}
	}
}

