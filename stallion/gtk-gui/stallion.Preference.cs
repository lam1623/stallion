
// This file has been generated by the GUI designer. Do not modify.
namespace stallion
{
	public partial class Preference
	{
		private global::Gtk.VBox dialog1_VBox1;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label3;
		private global::Gtk.HBox hbox1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label4;
		private global::Gtk.Entry entry_FileXmlOptions;
		private global::Gtk.Button btton_SelectXmlOptions;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label5;
		private global::Gtk.SpinButton spinbutton1;
		private global::Gtk.Label label6;
		private global::Gtk.CheckButton checkbutton1;
		private global::Gtk.CheckButton checkbutton3;
		private global::Gtk.CheckButton checkbutton4;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.CheckButton checkbutton5;
		private global::Gtk.Label label7;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget stallion.Preference
			this.Name = "stallion.Preference";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child stallion.Preference.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.dialog1_VBox1 = new global::Gtk.VBox ();
			this.dialog1_VBox1.Name = "dialog1_VBox1";
			this.dialog1_VBox1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Conversion options");
			this.vbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("File");
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry_FileXmlOptions = new global::Gtk.Entry ();
			this.entry_FileXmlOptions.CanFocus = true;
			this.entry_FileXmlOptions.Name = "entry_FileXmlOptions";
			this.entry_FileXmlOptions.IsEditable = true;
			this.entry_FileXmlOptions.InvisibleChar = '•';
			this.hbox3.Add (this.entry_FileXmlOptions);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry_FileXmlOptions]));
			w4.Position = 1;
			this.hbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox3]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btton_SelectXmlOptions = new global::Gtk.Button ();
			this.btton_SelectXmlOptions.CanFocus = true;
			this.btton_SelectXmlOptions.Name = "btton_SelectXmlOptions";
			this.btton_SelectXmlOptions.UseUnderline = true;
			// Container child btton_SelectXmlOptions.Gtk.Container+ContainerChild
			global::Gtk.Alignment w6 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w7 = new global::Gtk.HBox ();
			w7.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w8 = new global::Gtk.Image ();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-file", global::Gtk.IconSize.Menu);
			w7.Add (w8);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w10 = new global::Gtk.Label ();
			w10.LabelProp = global::Mono.Unix.Catalog.GetString ("Select");
			w10.UseUnderline = true;
			w7.Add (w10);
			w6.Add (w7);
			this.btton_SelectXmlOptions.Add (w6);
			this.hbox1.Add (this.btton_SelectXmlOptions);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btton_SelectXmlOptions]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Simultaneous conversions");
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinbutton1 = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbutton1.Sensitive = false;
			this.spinbutton1.CanFocus = true;
			this.spinbutton1.Name = "spinbutton1";
			this.spinbutton1.Adjustment.PageIncrement = 10;
			this.spinbutton1.ClimbRate = 1;
			this.spinbutton1.Numeric = true;
			this.spinbutton1.Value = 1;
			this.hbox2.Add (this.spinbutton1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.spinbutton1]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Select options");
			this.vbox2.Add (this.label6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label6]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkbutton1 = new global::Gtk.CheckButton ();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString ("Load subtitle files");
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			this.vbox2.Add (this.checkbutton1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkbutton1]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkbutton3 = new global::Gtk.CheckButton ();
			this.checkbutton3.CanFocus = true;
			this.checkbutton3.Name = "checkbutton3";
			this.checkbutton3.Label = global::Mono.Unix.Catalog.GetString ("Notify popups  ");
			this.checkbutton3.DrawIndicator = true;
			this.checkbutton3.UseUnderline = true;
			this.vbox2.Add (this.checkbutton3);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkbutton3]));
			w21.Position = 5;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkbutton4 = new global::Gtk.CheckButton ();
			this.checkbutton4.CanFocus = true;
			this.checkbutton4.Name = "checkbutton4";
			this.checkbutton4.Label = global::Mono.Unix.Catalog.GetString ("Shutdown when finished");
			this.checkbutton4.DrawIndicator = true;
			this.checkbutton4.UseUnderline = true;
			this.vbox2.Add (this.checkbutton4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkbutton4]));
			w22.Position = 6;
			w22.Expand = false;
			w22.Fill = false;
			this.notebook1.Add (this.vbox2);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("General");
			this.notebook1.SetTabLabel (this.vbox2, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkbutton5 = new global::Gtk.CheckButton ();
			this.checkbutton5.CanFocus = true;
			this.checkbutton5.Name = "checkbutton5";
			this.checkbutton5.Label = global::Mono.Unix.Catalog.GetString ("Show delete items dialog.");
			this.checkbutton5.DrawIndicator = true;
			this.checkbutton5.UseUnderline = true;
			this.vbox3.Add (this.checkbutton5);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.checkbutton5]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			this.notebook1.Add (this.vbox3);
			global::Gtk.Notebook.NotebookChild w25 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox3]));
			w25.Position = 1;
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Dialogs");
			this.notebook1.SetTabLabel (this.vbox3, this.label7);
			this.label7.ShowAll ();
			this.dialog1_VBox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox1 [this.notebook1]));
			w26.Position = 0;
			w1.Add (this.dialog1_VBox1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(w1 [this.dialog1_VBox1]));
			w27.Position = 0;
			// Internal child stallion.Preference.ActionArea
			global::Gtk.HButtonBox w28 = this.ActionArea;
			w28.Name = "dialog1_ActionArea";
			w28.Spacing = 10;
			w28.BorderWidth = ((uint)(5));
			w28.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w28 [this.buttonOk]));
			w29.Expand = false;
			w29.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 287;
			this.DefaultHeight = 347;
			this.Show ();
			this.btton_SelectXmlOptions.Clicked += new global::System.EventHandler (this.OnBttonSelectXmlOptionsClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}