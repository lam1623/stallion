
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action EditAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action aboutAction;
	private global::Gtk.Action preferenceAction;
	private global::Gtk.Action mediaPlayAction;
	private global::Gtk.Action mediaStopAction;
	private global::Gtk.Action removeAction;
	private global::Gtk.Action clearAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action openAction;
	private global::Gtk.Action openAction1;
	private global::Gtk.Action helpAction;
	private global::Gtk.VBox vbox3;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.VBox vbox6;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeview1;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label lbl1;
	private global::Gtk.ComboBox combobox1;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label lbl2;
	private global::Gtk.ComboBox combobox2;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label lbl3;
	private global::Gtk.Entry entry_FolderSave;
	private global::Gtk.Button button19;
	private global::Gtk.Button btton_SelectFolderSave;
	private global::Gtk.Notebook notebook3;
	private global::Gtk.VBox vbox7;
	private global::Gtk.Label lbl4;
	private global::Gtk.Label lbl5;
	private global::Gtk.Label lbl6;
	private global::Gtk.Label lbl7;
	private global::Gtk.Label lbl8;
	private global::Gtk.Label lbl9;
	private global::Gtk.Label lbl10;
	private global::Gtk.Label lbl11;
	private global::Gtk.Label lbl12;
	private global::Gtk.Image image3;
	private global::Gtk.Label lbl_information;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label lbl_video;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label lbl_size;
	private global::Gtk.SpinButton spinbutton1;
	private global::Gtk.SpinButton spinbutton2;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label lbl_bitrateVideo;
	private global::Gtk.SpinButton spinbtt_VideoBitrate;
	private global::Gtk.Label lbl_audio;
	private global::Gtk.HBox hbox10;
	private global::Gtk.Label lbl_bitrateAudio;
	private global::Gtk.SpinButton spinbtt_AudioBitrate;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HBox hbox8;
	private global::Gtk.Label label1;
	private global::Gtk.HScale hscale1;
	private global::Gtk.Label lbl_subtitle;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label lbl_subtitlefile;
	private global::Gtk.Entry entrySubtitle;
	private global::Gtk.Button btton_Subtitle;
	private global::Gtk.Button btton_SubtitleProperties;
	private global::Gtk.Label lbl_avanced;
	private global::Gtk.Expander expander;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TextView textview3;
	private global::Gtk.Label GtkLabel10;
	private global::Gtk.Statusbar statusbar1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.aboutAction, null);
		this.preferenceAction = new global::Gtk.Action ("preferenceAction", global::Mono.Unix.Catalog.GetString ("Preference"), null, "gtk-preferences");
		this.preferenceAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Preference");
		w1.Add (this.preferenceAction, null);
		this.mediaPlayAction = new global::Gtk.Action ("mediaPlayAction", null, null, "gtk-media-play");
		w1.Add (this.mediaPlayAction, null);
		this.mediaStopAction = new global::Gtk.Action ("mediaStopAction", null, null, "gtk-media-stop");
		this.mediaStopAction.Sensitive = false;
		w1.Add (this.mediaStopAction, null);
		this.removeAction = new global::Gtk.Action ("removeAction", null, null, "gtk-remove");
		w1.Add (this.removeAction, null);
		this.clearAction = new global::Gtk.Action ("clearAction", null, null, "gtk-clear");
		w1.Add (this.clearAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.quitAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
		w1.Add (this.openAction, null);
		this.openAction1 = new global::Gtk.Action ("openAction1", null, null, "gtk-open");
		w1.Add (this.openAction1, null);
		this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, "gtk-help");
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.helpAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Stallion");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.Modal = true;
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='EditAction' action='EditAction'><menuitem name='preferenceAction' action='preferenceAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='aboutAction' action='aboutAction'/><menuitem name='helpAction' action='helpAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox3.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='openAction1' action='openAction1'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaStopAction' action='mediaStopAction'/><toolitem name='removeAction' action='removeAction'/><toolitem name='clearAction' action='clearAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox3.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add (this.treeview1);
		this.vbox6.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.GtkScrolledWindow]));
		w5.Position = 0;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lbl1 = new global::Gtk.Label ();
		this.lbl1.Name = "lbl1";
		this.lbl1.LabelProp = global::Mono.Unix.Catalog.GetString ("Convert to:");
		this.hbox4.Add (this.lbl1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.lbl1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		w6.Padding = ((uint)(2));
		// Container child hbox4.Gtk.Box+BoxChild
		this.combobox1 = global::Gtk.ComboBox.NewText ();
		this.combobox1.WidthRequest = 500;
		this.combobox1.Name = "combobox1";
		this.hbox4.Add (this.combobox1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.combobox1]));
		w7.PackType = ((global::Gtk.PackType)(1));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox6.Add (this.hbox4);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox4]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lbl2 = new global::Gtk.Label ();
		this.lbl2.Name = "lbl2";
		this.lbl2.LabelProp = global::Mono.Unix.Catalog.GetString ("Variant:");
		this.hbox5.Add (this.lbl2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lbl2]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		w9.Padding = ((uint)(2));
		// Container child hbox5.Gtk.Box+BoxChild
		this.combobox2 = global::Gtk.ComboBox.NewText ();
		this.combobox2.WidthRequest = 500;
		this.combobox2.Name = "combobox2";
		this.hbox5.Add (this.combobox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.combobox2]));
		w10.PackType = ((global::Gtk.PackType)(1));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox6.Add (this.hbox5);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox5]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lbl3 = new global::Gtk.Label ();
		this.lbl3.Name = "lbl3";
		this.lbl3.LabelProp = global::Mono.Unix.Catalog.GetString ("Save to:");
		this.hbox2.Add (this.lbl3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lbl3]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		w12.Padding = ((uint)(2));
		// Container child hbox2.Gtk.Box+BoxChild
		this.entry_FolderSave = new global::Gtk.Entry ();
		this.entry_FolderSave.CanFocus = true;
		this.entry_FolderSave.Name = "entry_FolderSave";
		this.entry_FolderSave.IsEditable = true;
		this.entry_FolderSave.InvisibleChar = '●';
		this.hbox2.Add (this.entry_FolderSave);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entry_FolderSave]));
		w13.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button19 = new global::Gtk.Button ();
		this.button19.TooltipMarkup = "Open directory";
		this.button19.CanFocus = true;
		this.button19.Name = "button19";
		this.button19.UseStock = true;
		this.button19.UseUnderline = true;
		this.button19.Label = "gtk-open";
		this.hbox2.Add (this.button19);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button19]));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btton_SelectFolderSave = new global::Gtk.Button ();
		this.btton_SelectFolderSave.CanFocus = true;
		this.btton_SelectFolderSave.Name = "btton_SelectFolderSave";
		this.btton_SelectFolderSave.UseUnderline = true;
		// Container child btton_SelectFolderSave.Gtk.Container+ContainerChild
		global::Gtk.Alignment w15 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w16 = new global::Gtk.HBox ();
		w16.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w17 = new global::Gtk.Image ();
		w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
		w16.Add (w17);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w19 = new global::Gtk.Label ();
		w19.LabelProp = global::Mono.Unix.Catalog.GetString ("Select");
		w19.UseUnderline = true;
		w16.Add (w19);
		w15.Add (w16);
		this.btton_SelectFolderSave.Add (w15);
		this.hbox2.Add (this.btton_SelectFolderSave);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btton_SelectFolderSave]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 3;
		w23.Expand = false;
		w23.Fill = false;
		this.vbox6.Add (this.hbox2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox2]));
		w24.PackType = ((global::Gtk.PackType)(1));
		w24.Position = 3;
		w24.Expand = false;
		w24.Fill = false;
		this.hbox1.Add (this.vbox6);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox6]));
		w25.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.notebook3 = new global::Gtk.Notebook ();
		this.notebook3.WidthRequest = 225;
		this.notebook3.CanFocus = true;
		this.notebook3.Name = "notebook3";
		this.notebook3.CurrentPage = 1;
		// Container child notebook3.Gtk.Notebook+NotebookChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl4 = new global::Gtk.Label ();
		this.lbl4.Name = "lbl4";
		this.lbl4.Ypad = 5;
		this.lbl4.LabelProp = global::Mono.Unix.Catalog.GetString ("Basic properties");
		this.vbox7.Add (this.lbl4);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl4]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl5 = new global::Gtk.Label ();
		this.lbl5.Name = "lbl5";
		this.lbl5.LabelProp = global::Mono.Unix.Catalog.GetString ("Video");
		this.vbox7.Add (this.lbl5);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl5]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl6 = new global::Gtk.Label ();
		this.lbl6.Name = "lbl6";
		this.lbl6.LabelProp = global::Mono.Unix.Catalog.GetString ("duration:");
		this.vbox7.Add (this.lbl6);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl6]));
		w28.Position = 2;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl7 = new global::Gtk.Label ();
		this.lbl7.Name = "lbl7";
		this.lbl7.LabelProp = global::Mono.Unix.Catalog.GetString ("dimensions:");
		this.vbox7.Add (this.lbl7);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl7]));
		w29.Position = 3;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl8 = new global::Gtk.Label ();
		this.lbl8.Name = "lbl8";
		this.lbl8.LabelProp = global::Mono.Unix.Catalog.GetString ("video code:");
		this.vbox7.Add (this.lbl8);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl8]));
		w30.Position = 4;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl9 = new global::Gtk.Label ();
		this.lbl9.Name = "lbl9";
		this.lbl9.LabelProp = global::Mono.Unix.Catalog.GetString ("Video Bitrate:");
		this.vbox7.Add (this.lbl9);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl9]));
		w31.Position = 5;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl10 = new global::Gtk.Label ();
		this.lbl10.Name = "lbl10";
		this.lbl10.LabelProp = global::Mono.Unix.Catalog.GetString ("Sound");
		this.vbox7.Add (this.lbl10);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl10]));
		w32.Position = 6;
		w32.Expand = false;
		w32.Fill = false;
		w32.Padding = ((uint)(6));
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl11 = new global::Gtk.Label ();
		this.lbl11.Name = "lbl11";
		this.lbl11.LabelProp = global::Mono.Unix.Catalog.GetString ("audio bitrate:");
		this.vbox7.Add (this.lbl11);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl11]));
		w33.Position = 7;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.lbl12 = new global::Gtk.Label ();
		this.lbl12.Name = "lbl12";
		this.lbl12.LabelProp = global::Mono.Unix.Catalog.GetString ("audio code:");
		this.vbox7.Add (this.lbl12);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.lbl12]));
		w34.Position = 8;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.image3 = new global::Gtk.Image ();
		this.image3.HeightRequest = 104;
		this.image3.Name = "image3";
		this.vbox7.Add (this.image3);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.image3]));
		w35.Position = 9;
		this.notebook3.Add (this.vbox7);
		// Notebook tab
		this.lbl_information = new global::Gtk.Label ();
		this.lbl_information.Name = "lbl_information";
		this.lbl_information.LabelProp = global::Mono.Unix.Catalog.GetString ("Information");
		this.notebook3.SetTabLabel (this.vbox7, this.lbl_information);
		this.lbl_information.ShowAll ();
		// Container child notebook3.Gtk.Notebook+NotebookChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lbl_video = new global::Gtk.Label ();
		this.lbl_video.Name = "lbl_video";
		this.lbl_video.LabelProp = global::Mono.Unix.Catalog.GetString ("Video options");
		this.vbox2.Add (this.lbl_video);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lbl_video]));
		w37.Position = 0;
		w37.Expand = false;
		w37.Fill = false;
		w37.Padding = ((uint)(5));
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lbl_size = new global::Gtk.Label ();
		this.lbl_size.Name = "lbl_size";
		this.lbl_size.LabelProp = global::Mono.Unix.Catalog.GetString ("Size");
		this.hbox6.Add (this.lbl_size);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lbl_size]));
		w38.Position = 0;
		w38.Expand = false;
		w38.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.spinbutton1 = new global::Gtk.SpinButton (0, 1000, 1);
		this.spinbutton1.Sensitive = false;
		this.spinbutton1.CanFocus = true;
		this.spinbutton1.Name = "spinbutton1";
		this.spinbutton1.Adjustment.PageIncrement = 10;
		this.spinbutton1.ClimbRate = 1;
		this.spinbutton1.Numeric = true;
		this.hbox6.Add (this.spinbutton1);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.spinbutton1]));
		w39.Position = 1;
		w39.Expand = false;
		w39.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.spinbutton2 = new global::Gtk.SpinButton (0, 1000, 1);
		this.spinbutton2.Sensitive = false;
		this.spinbutton2.CanFocus = true;
		this.spinbutton2.Name = "spinbutton2";
		this.spinbutton2.Adjustment.PageIncrement = 10;
		this.spinbutton2.ClimbRate = 1;
		this.spinbutton2.Numeric = true;
		this.hbox6.Add (this.spinbutton2);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.spinbutton2]));
		w40.Position = 2;
		w40.Expand = false;
		w40.Fill = false;
		this.vbox2.Add (this.hbox6);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
		w41.Position = 1;
		w41.Expand = false;
		w41.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lbl_bitrateVideo = new global::Gtk.Label ();
		this.lbl_bitrateVideo.Name = "lbl_bitrateVideo";
		this.lbl_bitrateVideo.LabelProp = global::Mono.Unix.Catalog.GetString ("Bitrate");
		this.hbox3.Add (this.lbl_bitrateVideo);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lbl_bitrateVideo]));
		w42.Position = 0;
		w42.Expand = false;
		w42.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.spinbtt_VideoBitrate = new global::Gtk.SpinButton (0, 5000, 1);
		this.spinbtt_VideoBitrate.Sensitive = false;
		this.spinbtt_VideoBitrate.CanFocus = true;
		this.spinbtt_VideoBitrate.Name = "spinbtt_VideoBitrate";
		this.spinbtt_VideoBitrate.Adjustment.PageIncrement = 10;
		this.spinbtt_VideoBitrate.ClimbRate = 1;
		this.spinbtt_VideoBitrate.Numeric = true;
		this.hbox3.Add (this.spinbtt_VideoBitrate);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spinbtt_VideoBitrate]));
		w43.Position = 1;
		w43.Expand = false;
		w43.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w44.Position = 2;
		w44.Expand = false;
		w44.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lbl_audio = new global::Gtk.Label ();
		this.lbl_audio.Name = "lbl_audio";
		this.lbl_audio.LabelProp = global::Mono.Unix.Catalog.GetString ("Audio opctions");
		this.vbox2.Add (this.lbl_audio);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lbl_audio]));
		w45.Position = 3;
		w45.Expand = false;
		w45.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.lbl_bitrateAudio = new global::Gtk.Label ();
		this.lbl_bitrateAudio.Name = "lbl_bitrateAudio";
		this.lbl_bitrateAudio.LabelProp = global::Mono.Unix.Catalog.GetString ("Bitrate");
		this.hbox10.Add (this.lbl_bitrateAudio);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.lbl_bitrateAudio]));
		w46.Position = 0;
		w46.Expand = false;
		w46.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.spinbtt_AudioBitrate = new global::Gtk.SpinButton (0, 500, 1);
		this.spinbtt_AudioBitrate.Sensitive = false;
		this.spinbtt_AudioBitrate.CanFocus = true;
		this.spinbtt_AudioBitrate.Name = "spinbtt_AudioBitrate";
		this.spinbtt_AudioBitrate.Adjustment.PageIncrement = 10;
		this.spinbtt_AudioBitrate.ClimbRate = 1;
		this.spinbtt_AudioBitrate.Numeric = true;
		this.hbox10.Add (this.spinbtt_AudioBitrate);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.spinbtt_AudioBitrate]));
		w47.Position = 1;
		w47.Expand = false;
		w47.Fill = false;
		this.vbox2.Add (this.hbox10);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox10]));
		w48.Position = 4;
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Increase volumen");
		this.hbox8.Add (this.label1);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label1]));
		w49.Position = 0;
		w49.Expand = false;
		w49.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.hscale1 = new global::Gtk.HScale (null);
		this.hscale1.CanFocus = true;
		this.hscale1.Name = "hscale1";
		this.hscale1.Adjustment.Upper = 100;
		this.hscale1.Adjustment.PageIncrement = 10;
		this.hscale1.Adjustment.StepIncrement = 1;
		this.hscale1.DrawValue = true;
		this.hscale1.Digits = 0;
		this.hscale1.ValuePos = ((global::Gtk.PositionType)(1));
		this.hbox8.Add (this.hscale1);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.hscale1]));
		w50.Position = 1;
		this.vbox4.Add (this.hbox8);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox8]));
		w51.Position = 0;
		w51.Expand = false;
		w51.Fill = false;
		this.vbox2.Add (this.vbox4);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox4]));
		w52.Position = 5;
		w52.Expand = false;
		w52.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lbl_subtitle = new global::Gtk.Label ();
		this.lbl_subtitle.Name = "lbl_subtitle";
		this.lbl_subtitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Subtitle options");
		this.vbox2.Add (this.lbl_subtitle);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lbl_subtitle]));
		w53.Position = 6;
		w53.Expand = false;
		w53.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lbl_subtitlefile = new global::Gtk.Label ();
		this.lbl_subtitlefile.Name = "lbl_subtitlefile";
		this.lbl_subtitlefile.LabelProp = global::Mono.Unix.Catalog.GetString ("File");
		this.hbox7.Add (this.lbl_subtitlefile);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lbl_subtitlefile]));
		w54.Position = 0;
		w54.Expand = false;
		w54.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entrySubtitle = new global::Gtk.Entry ();
		this.entrySubtitle.Sensitive = false;
		this.entrySubtitle.CanFocus = true;
		this.entrySubtitle.Name = "entrySubtitle";
		this.entrySubtitle.IsEditable = true;
		this.entrySubtitle.InvisibleChar = '•';
		this.hbox7.Add (this.entrySubtitle);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entrySubtitle]));
		w55.Position = 1;
		// Container child hbox7.Gtk.Box+BoxChild
		this.btton_Subtitle = new global::Gtk.Button ();
		this.btton_Subtitle.TooltipMarkup = "load file";
		this.btton_Subtitle.Sensitive = false;
		this.btton_Subtitle.CanFocus = true;
		this.btton_Subtitle.Name = "btton_Subtitle";
		this.btton_Subtitle.UseUnderline = true;
		this.btton_Subtitle.Xalign = 1F;
		// Container child btton_Subtitle.Gtk.Container+ContainerChild
		global::Gtk.Alignment w56 = new global::Gtk.Alignment (1F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w57 = new global::Gtk.HBox ();
		w57.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w58 = new global::Gtk.Image ();
		w58.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-file", global::Gtk.IconSize.Menu);
		w57.Add (w58);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w60 = new global::Gtk.Label ();
		w57.Add (w60);
		w56.Add (w57);
		this.btton_Subtitle.Add (w56);
		this.hbox7.Add (this.btton_Subtitle);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.btton_Subtitle]));
		w64.Position = 2;
		w64.Expand = false;
		w64.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.btton_SubtitleProperties = new global::Gtk.Button ();
		this.btton_SubtitleProperties.TooltipMarkup = "subtitle properties";
		this.btton_SubtitleProperties.Sensitive = false;
		this.btton_SubtitleProperties.CanFocus = true;
		this.btton_SubtitleProperties.Name = "btton_SubtitleProperties";
		this.btton_SubtitleProperties.UseUnderline = true;
		this.btton_SubtitleProperties.Xalign = 1F;
		// Container child btton_SubtitleProperties.Gtk.Container+ContainerChild
		global::Gtk.Alignment w65 = new global::Gtk.Alignment (1F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w66 = new global::Gtk.HBox ();
		w66.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w67 = new global::Gtk.Image ();
		w67.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-properties", global::Gtk.IconSize.Menu);
		w66.Add (w67);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w69 = new global::Gtk.Label ();
		w66.Add (w69);
		w65.Add (w66);
		this.btton_SubtitleProperties.Add (w65);
		this.hbox7.Add (this.btton_SubtitleProperties);
		global::Gtk.Box.BoxChild w73 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.btton_SubtitleProperties]));
		w73.Position = 3;
		w73.Expand = false;
		w73.Fill = false;
		this.vbox2.Add (this.hbox7);
		global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
		w74.Position = 7;
		w74.Expand = false;
		w74.Fill = false;
		this.notebook3.Add (this.vbox2);
		global::Gtk.Notebook.NotebookChild w75 = ((global::Gtk.Notebook.NotebookChild)(this.notebook3 [this.vbox2]));
		w75.Position = 1;
		// Notebook tab
		this.lbl_avanced = new global::Gtk.Label ();
		this.lbl_avanced.Name = "lbl_avanced";
		this.lbl_avanced.LabelProp = global::Mono.Unix.Catalog.GetString ("Avanced");
		this.notebook3.SetTabLabel (this.vbox2, this.lbl_avanced);
		this.lbl_avanced.ShowAll ();
		this.hbox1.Add (this.notebook3);
		global::Gtk.Box.BoxChild w76 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.notebook3]));
		w76.PackType = ((global::Gtk.PackType)(1));
		w76.Position = 1;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w77 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w77.Position = 2;
		// Container child vbox3.Gtk.Box+BoxChild
		this.expander = new global::Gtk.Expander (null);
		this.expander.CanFocus = true;
		this.expander.ExtensionEvents = ((global::Gdk.ExtensionMode)(2));
		this.expander.Name = "expander";
		// Container child expander.Gtk.Container+ContainerChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textview3 = new global::Gtk.TextView ();
		this.textview3.HeightRequest = 116;
		this.textview3.CanFocus = true;
		this.textview3.Name = "textview3";
		this.GtkScrolledWindow1.Add (this.textview3);
		this.expander.Add (this.GtkScrolledWindow1);
		this.GtkLabel10 = new global::Gtk.Label ();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("Conversion details");
		this.GtkLabel10.UseUnderline = true;
		this.expander.LabelWidget = this.GtkLabel10;
		this.vbox3.Add (this.expander);
		global::Gtk.Box.BoxChild w80 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.expander]));
		w80.Position = 3;
		w80.Padding = ((uint)(6));
		// Container child vbox3.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox3.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w81 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.statusbar1]));
		w81.PackType = ((global::Gtk.PackType)(1));
		w81.Position = 4;
		w81.Expand = false;
		w81.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 818;
		this.DefaultHeight = 519;
		this.Show ();
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.preferenceAction.Activated += new global::System.EventHandler (this.OnPreferenceActionActivated);
		this.mediaPlayAction.Activated += new global::System.EventHandler (this.OnMediaPlayActionActivated);
		this.mediaStopAction.Activated += new global::System.EventHandler (this.OnMediaStopActionActivated);
		this.removeAction.Activated += new global::System.EventHandler (this.OnRemoveActionActivated);
		this.clearAction.Activated += new global::System.EventHandler (this.OnClearActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitAction1Activated);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.openAction1.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.helpAction.Activated += new global::System.EventHandler (this.OnHelpActionActivated);
		this.treeview1.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTreeview1KeyPressEvent);
		this.treeview1.CursorChanged += new global::System.EventHandler (this.OnTreeview1CursorChanged);
		this.combobox1.Changed += new global::System.EventHandler (this.OnCombobox1Changed);
		this.combobox2.Changed += new global::System.EventHandler (this.OnCombobox2Changed);
		this.button19.Clicked += new global::System.EventHandler (this.OnButton19Clicked);
		this.btton_SelectFolderSave.Clicked += new global::System.EventHandler (this.OnBttonSelectFolderSaveClicked);
		this.spinbutton1.ValueChanged += new global::System.EventHandler (this.OnSpinbutton1ValueChanged);
		this.spinbutton2.ValueChanged += new global::System.EventHandler (this.OnSpinbutton2ValueChanged);
		this.spinbtt_VideoBitrate.ValueChanged += new global::System.EventHandler (this.OnSpinbttVideoBitrateValueChanged);
		this.spinbtt_AudioBitrate.ValueChanged += new global::System.EventHandler (this.OnSpinbttAudioBitrateValueChanged);
		this.btton_Subtitle.Clicked += new global::System.EventHandler (this.OnBttonSubtitleClicked);
		this.btton_SubtitleProperties.Clicked += new global::System.EventHandler (this.OnBttonSubtitlePropertiesClicked);
	}
}
