
// This file has been generated by the GUI designer. Do not modify.
namespace TextureMerger
{
	public partial class ImageSelector
	{
		private global::Gtk.VBox selector;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label lblEmpty1;
		private global::Gtk.Button selectorMinus;
		private global::Gtk.Button selectorPlus;
		private global::Gtk.Label lblEmpty2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TextureMerger.ImageSelector
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TextureMerger.ImageSelector";
			// Container child TextureMerger.ImageSelector.Gtk.Container+ContainerChild
			this.selector = new global::Gtk.VBox ();
			this.selector.Name = "selector";
			this.selector.Spacing = 6;
			// Container child selector.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblEmpty1 = new global::Gtk.Label ();
			this.lblEmpty1.WidthRequest = 30;
			this.lblEmpty1.Name = "lblEmpty1";
			this.lblEmpty1.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox2.Add (this.lblEmpty1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lblEmpty1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.selectorMinus = new global::Gtk.Button ();
			this.selectorMinus.WidthRequest = 22;
			this.selectorMinus.CanFocus = true;
			this.selectorMinus.Name = "selectorMinus";
			this.selectorMinus.UseUnderline = true;
			this.selectorMinus.Label = global::Mono.Unix.Catalog.GetString ("-");
			this.hbox2.Add (this.selectorMinus);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.selectorMinus]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.selectorPlus = new global::Gtk.Button ();
			this.selectorPlus.WidthRequest = 22;
			this.selectorPlus.CanFocus = true;
			this.selectorPlus.Name = "selectorPlus";
			this.selectorPlus.UseUnderline = true;
			this.selectorPlus.Label = global::Mono.Unix.Catalog.GetString ("+");
			this.hbox2.Add (this.selectorPlus);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.selectorPlus]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblEmpty2 = new global::Gtk.Label ();
			this.lblEmpty2.WidthRequest = 300;
			this.lblEmpty2.Name = "lblEmpty2";
			this.lblEmpty2.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox2.Add (this.lblEmpty2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lblEmpty2]));
			w4.Position = 3;
			this.selector.Add (this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.selector [this.hbox2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.selector);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.selectorMinus.Clicked += new global::System.EventHandler (this.OnSelectorMinusClicked);
			this.selectorPlus.Clicked += new global::System.EventHandler (this.OnSelectorPlusClicked);
		}
	}
}
