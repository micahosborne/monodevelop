
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.CodeFormatting
{
	public partial class CodeFormattingPolicyPanelWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.VPaned vpaned1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeviewCategories;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.CheckButton checkbuttonWhiteSpaces;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.CodeFormatting.CodeFormattingPolicyPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.CodeFormatting.CodeFormattingPolicyPanelWidget";
			// Container child MonoDevelop.Ide.CodeFormatting.CodeFormattingPolicyPanelWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 148;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewCategories = new global::Gtk.TreeView ();
			this.treeviewCategories.CanFocus = true;
			this.treeviewCategories.Name = "treeviewCategories";
			this.GtkScrolledWindow.Add (this.treeviewCategories);
			this.vpaned1.Add (this.GtkScrolledWindow);
			global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.GtkScrolledWindow]));
			w2.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview:");
			this.hbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed1]));
			w4.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkbuttonWhiteSpaces = new global::Gtk.CheckButton ();
			this.checkbuttonWhiteSpaces.CanFocus = true;
			this.checkbuttonWhiteSpaces.Name = "checkbuttonWhiteSpaces";
			this.checkbuttonWhiteSpaces.Label = global::Mono.Unix.Catalog.GetString ("S_how whitespaces");
			this.checkbuttonWhiteSpaces.DrawIndicator = true;
			this.checkbuttonWhiteSpaces.UseUnderline = true;
			this.hbox2.Add (this.checkbuttonWhiteSpaces);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkbuttonWhiteSpaces]));
			w5.Position = 2;
			w5.Expand = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox4.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.scrolledwindow2]));
			w7.Position = 1;
			this.vpaned1.Add (this.vbox4);
			this.vbox2.Add (this.vpaned1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vpaned1]));
			w9.Position = 0;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}