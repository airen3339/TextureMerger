
// This file has been generated by the GUI designer. Do not modify.
namespace TextureMerger
{
	public partial class MainWindows
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action FileAction;
		private global::Gtk.Action PreferencesAction;
		private global::Gtk.Action ClearNewAction;
		private global::Gtk.Action QuitAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Label title;
		private global::Gtk.HSeparator hseparator3;
		private global::RLToolkit.Widgets.DynamicRow dynamicrow1;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Label LabelParam;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label lblFormat;
		private global::Gtk.ComboBox comboFormat;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label lblSize;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Entry txtWidth;
		private global::Gtk.Label label1;
		private global::Gtk.Entry txtHeight;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label lblProportion;
		private global::Gtk.CheckButton chkProportion;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label labelOutput;
		private global::Gtk.Label lblPath;
		private global::Gtk.Entry txtFilename;
		private global::Gtk.Label lblExtension;
		private global::Gtk.Button BtnBrowse;
		private global::Gtk.Button btnGo;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TextureMerger.MainWindows
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.PreferencesAction = new global::Gtk.Action ("PreferencesAction", global::Mono.Unix.Catalog.GetString ("Preferences"), null, null);
			this.PreferencesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Preferences");
			w1.Add (this.PreferencesAction, null);
			this.ClearNewAction = new global::Gtk.Action ("ClearNewAction", global::Mono.Unix.Catalog.GetString ("Clear/New"), null, null);
			this.ClearNewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Clear");
			w1.Add (this.ClearNewAction, null);
			this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
			this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
			w1.Add (this.QuitAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "TextureMerger.MainWindows";
			this.Title = global::Mono.Unix.Catalog.GetString ("Texture Merger");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 600;
			this.DefaultHeight = 210;
			// Container child TextureMerger.MainWindows.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='ClearNewAction' action='ClearNewAction'/><menuitem name='PreferencesAction' action='PreferencesAction'/><menuitem name='QuitAction' action='QuitAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.title = new global::Gtk.Label ();
			this.title.Name = "title";
			this.title.LabelProp = global::Mono.Unix.Catalog.GetString ("Texture Merger");
			this.title.Justify = ((global::Gtk.Justification)(2));
			this.vbox1.Add (this.title);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.title]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox1.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator3]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.dynamicrow1 = new global::RLToolkit.Widgets.DynamicRow ();
			this.dynamicrow1.Events = ((global::Gdk.EventMask)(256));
			this.dynamicrow1.Name = "dynamicrow1";
			this.vbox1.Add (this.dynamicrow1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.dynamicrow1]));
			w5.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox1.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator2]));
			w6.Position = 4;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.LabelParam = new global::Gtk.Label ();
			this.LabelParam.Name = "LabelParam";
			this.LabelParam.LabelProp = global::Mono.Unix.Catalog.GetString ("Output Parameters");
			this.vbox1.Add (this.LabelParam);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.LabelParam]));
			w7.Position = 5;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lblFormat = new global::Gtk.Label ();
			this.lblFormat.Name = "lblFormat";
			this.lblFormat.Xalign = 0F;
			this.lblFormat.LabelProp = global::Mono.Unix.Catalog.GetString ("Format: ");
			this.hbox1.Add (this.lblFormat);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lblFormat]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Padding = ((uint)(15));
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboFormat = global::Gtk.ComboBox.NewText ();
			this.comboFormat.AppendText (global::Mono.Unix.Catalog.GetString ("Bmp"));
			this.comboFormat.AppendText (global::Mono.Unix.Catalog.GetString ("Png"));
			this.comboFormat.AppendText (global::Mono.Unix.Catalog.GetString ("Jpg"));
			this.comboFormat.Name = "comboFormat";
			this.comboFormat.Active = 0;
			this.hbox1.Add (this.comboFormat);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboFormat]));
			w9.Position = 1;
			w9.Expand = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			this.hbox3.BorderWidth = ((uint)(3));
			// Container child hbox3.Gtk.Box+BoxChild
			this.lblSize = new global::Gtk.Label ();
			this.lblSize.Name = "lblSize";
			this.lblSize.Xalign = 0F;
			this.lblSize.LabelProp = global::Mono.Unix.Catalog.GetString ("Size: ");
			this.hbox3.Add (this.lblSize);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lblSize]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Padding = ((uint)(15));
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.txtWidth = new global::Gtk.Entry ();
			this.txtWidth.CanFocus = true;
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Text = global::Mono.Unix.Catalog.GetString ("512");
			this.txtWidth.IsEditable = true;
			this.txtWidth.InvisibleChar = '•';
			this.hbox4.Add (this.txtWidth);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtWidth]));
			w12.Position = 0;
			w12.Expand = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("x");
			this.hbox4.Add (this.label1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.txtHeight = new global::Gtk.Entry ();
			this.txtHeight.CanFocus = true;
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Text = global::Mono.Unix.Catalog.GetString ("512");
			this.txtHeight.IsEditable = true;
			this.txtHeight.InvisibleChar = '•';
			this.hbox4.Add (this.txtHeight);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtHeight]));
			w14.Position = 2;
			w14.Expand = false;
			this.hbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox4]));
			w15.Position = 1;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w16.Position = 7;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Homogeneous = true;
			this.hbox5.Spacing = 6;
			this.hbox5.BorderWidth = ((uint)(3));
			// Container child hbox5.Gtk.Box+BoxChild
			this.lblProportion = new global::Gtk.Label ();
			this.lblProportion.Name = "lblProportion";
			this.lblProportion.Xalign = 0F;
			this.lblProportion.LabelProp = global::Mono.Unix.Catalog.GetString ("Keep Proportions:");
			this.hbox5.Add (this.lblProportion);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lblProportion]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Padding = ((uint)(15));
			// Container child hbox5.Gtk.Box+BoxChild
			this.chkProportion = new global::Gtk.CheckButton ();
			this.chkProportion.CanFocus = true;
			this.chkProportion.Name = "chkProportion";
			this.chkProportion.Label = global::Mono.Unix.Catalog.GetString ("Keep");
			this.chkProportion.DrawIndicator = true;
			this.chkProportion.UseUnderline = true;
			this.hbox5.Add (this.chkProportion);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.chkProportion]));
			w18.Position = 1;
			this.vbox1.Add (this.hbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
			w19.Position = 8;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelOutput = new global::Gtk.Label ();
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.LabelProp = global::Mono.Unix.Catalog.GetString ("Output: ");
			this.hbox6.Add (this.labelOutput);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelOutput]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			w20.Padding = ((uint)(5));
			// Container child hbox6.Gtk.Box+BoxChild
			this.lblPath = new global::Gtk.Label ();
			this.lblPath.Name = "lblPath";
			this.lblPath.LabelProp = global::Mono.Unix.Catalog.GetString ("~/TextureMerger/");
			this.hbox6.Add (this.lblPath);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lblPath]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.txtFilename = new global::Gtk.Entry ();
			this.txtFilename.CanFocus = true;
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Text = global::Mono.Unix.Catalog.GetString ("output");
			this.txtFilename.IsEditable = true;
			this.txtFilename.InvisibleChar = '•';
			this.hbox6.Add (this.txtFilename);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtFilename]));
			w22.Position = 2;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lblExtension = new global::Gtk.Label ();
			this.lblExtension.Name = "lblExtension";
			this.lblExtension.LabelProp = global::Mono.Unix.Catalog.GetString (".png");
			this.hbox6.Add (this.lblExtension);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lblExtension]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.BtnBrowse = new global::Gtk.Button ();
			this.BtnBrowse.CanFocus = true;
			this.BtnBrowse.Name = "BtnBrowse";
			this.BtnBrowse.UseUnderline = true;
			this.BtnBrowse.Label = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox6.Add (this.BtnBrowse);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.BtnBrowse]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnGo = new global::Gtk.Button ();
			this.btnGo.CanFocus = true;
			this.btnGo.Name = "btnGo";
			this.btnGo.UseUnderline = true;
			this.btnGo.Label = global::Mono.Unix.Catalog.GetString ("Merge");
			this.hbox6.Add (this.btnGo);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.btnGo]));
			w25.Position = 5;
			w25.Expand = false;
			w25.Fill = false;
			w25.Padding = ((uint)(5));
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w26.Position = 9;
			w26.Expand = false;
			w26.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.PreferencesAction.Activated += new global::System.EventHandler (this.OnPreferencesActionActivated);
			this.ClearNewAction.Activated += new global::System.EventHandler (this.OnClearActionActivated);
			this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
			this.comboFormat.Changed += new global::System.EventHandler (this.OnComboFormatChanged);
			this.txtWidth.FocusOutEvent += new global::Gtk.FocusOutEventHandler (this.OnTxtWidthFocusOutEvent);
			this.txtHeight.FocusOutEvent += new global::Gtk.FocusOutEventHandler (this.OnTxtHeightFocusOutEvent);
			this.chkProportion.Toggled += new global::System.EventHandler (this.OnChkProportionToggled);
			this.BtnBrowse.Clicked += new global::System.EventHandler (this.OnBtnBrowseClicked);
			this.btnGo.Clicked += new global::System.EventHandler (this.OnBtnGoClicked);
		}
	}
}
