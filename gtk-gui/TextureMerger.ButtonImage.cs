
// This file has been generated by the GUI designer. Do not modify.
namespace TextureMerger
{
	public partial class ButtonImage
	{
		private global::Gtk.HBox buttonControl;
		private global::Gtk.Button btn;
		private global::Gtk.Image img;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TextureMerger.ButtonImage
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TextureMerger.ButtonImage";
			// Container child TextureMerger.ButtonImage.Gtk.Container+ContainerChild
			this.buttonControl = new global::Gtk.HBox ();
			this.buttonControl.Name = "buttonControl";
			this.buttonControl.Homogeneous = true;
			this.buttonControl.Spacing = 6;
			// Container child buttonControl.Gtk.Box+BoxChild
			this.btn = new global::Gtk.Button ();
			this.btn.CanFocus = true;
			this.btn.Name = "btn";
			// Container child btn.Gtk.Container+ContainerChild
			this.img = new global::Gtk.Image ();
			this.img.Name = "img";
			this.btn.Add (this.img);
			this.btn.Label = null;
			this.buttonControl.Add (this.btn);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.buttonControl [this.btn]));
			w2.Position = 0;
			this.Add (this.buttonControl);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.btn.Clicked += new global::System.EventHandler (this.OnBtnClicked);
		}
	}
}
