using System;
using Gtk;

namespace stallion
{
	public class SelectFileAndFolder
	{
		private string titleDialog;
		private bool selectMultipleDialog = false;
		private string currentFolderDialog;		
		private MainWindow mainWindow;

		public SelectFileAndFolder(string titleDialog, bool selectMultipleDialog, string currentFolderDialog,MainWindow mainWindow)		
		{
			this.titleDialog = titleDialog;
			this.selectMultipleDialog = selectMultipleDialog;
			this.currentFolderDialog = currentFolderDialog;
			this.mainWindow = mainWindow;
		}
		
		public FileFilter addfilter(string name,params string[] filtros)
		{		
			FileFilter filter = new FileFilter();
			filter.Name = name;			
			 for (int i=0;i<filtros.Length;i++)			
			   filter.AddPattern(filtros[i]);		
			
			return filter;
		}	
		
		public string[] CreateWindows(FileChooserAction FileChooserAction,params FileFilter[] Filtro)
		{
			string[] result = null;
			FileChooserDialog dialog = new FileChooserDialog( titleDialog,
								                              mainWindow,
								                              FileChooserAction,		                         
								                              "Cancelar",ResponseType.Cancel,
								                              "Abrir",ResponseType.Ok);
			dialog.DefaultHeight = 50;
			dialog.DefaultWidth = 50;
			dialog.Modal = true;			
			dialog.SelectMultiple = this.selectMultipleDialog;
			for (int i=0;i<Filtro.Length;i++)
				dialog.AddFilter(Filtro[i]);					                 
			dialog.SetCurrentFolder(this.currentFolderDialog);
			if (dialog.Run() == (int) ResponseType.Ok )	{
				result = new string[dialog.Filenames.Length];
				for (int i=0;i<dialog.Filenames.Length;i++)
					result[i] = dialog.Filenames[i];	
			} 
			dialog.Destroy();
			return result;
		}
	}
}

