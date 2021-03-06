
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects
{
	public partial class ConfirmProjectDeleteDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.RadioButton radioDeleteAll;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Label labelProjectDir;
		private global::Gtk.RadioButton radioDeleteSel;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView fileList;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.ConfirmProjectDeleteDialog
			this.Name = "MonoDevelop.Ide.Projects.ConfirmProjectDeleteDialog";
			this.Title = global::MonoDevelop.Core.GettextCatalog.GetString ("Delete Project");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child MonoDevelop.Ide.Projects.ConfirmProjectDeleteDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Please select which files and folders you want to delete:");
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioDeleteAll = new global::Gtk.RadioButton (global::MonoDevelop.Core.GettextCatalog.GetString ("Delete the project file and the whole project directory:"));
			this.radioDeleteAll.CanFocus = true;
			this.radioDeleteAll.Name = "radioDeleteAll";
			this.radioDeleteAll.Active = true;
			this.radioDeleteAll.DrawIndicator = true;
			this.radioDeleteAll.UseUnderline = true;
			this.radioDeleteAll.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox2.Add (this.radioDeleteAll);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radioDeleteAll]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(30));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.labelProjectDir = new global::Gtk.Label ();
			this.labelProjectDir.Name = "labelProjectDir";
			this.labelProjectDir.Xalign = 0F;
			this.labelProjectDir.LabelProp = "label2";
			this.alignment1.Add (this.labelProjectDir);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioDeleteSel = new global::Gtk.RadioButton (global::MonoDevelop.Core.GettextCatalog.GetString ("Delete the following files and folders:"));
			this.radioDeleteSel.CanFocus = true;
			this.radioDeleteSel.Name = "radioDeleteSel";
			this.radioDeleteSel.DrawIndicator = true;
			this.radioDeleteSel.UseUnderline = true;
			this.radioDeleteSel.Group = this.radioDeleteAll.Group;
			this.vbox2.Add (this.radioDeleteSel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radioDeleteSel]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(30));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.fileList = new global::Gtk.TreeView ();
			this.fileList.CanFocus = true;
			this.fileList.Name = "fileList";
			this.fileList.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.fileList);
			this.alignment2.Add (this.GtkScrolledWindow);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w9.Position = 4;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w10.Position = 0;
			// Internal child MonoDevelop.Ide.Projects.ConfirmProjectDeleteDialog.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Name = "dialog1_ActionArea";
			w11.Spacing = 10;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonCancel]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-delete";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonOk]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 512;
			this.DefaultHeight = 387;
			this.Hide ();
			this.radioDeleteAll.Toggled += new global::System.EventHandler (this.OnRadioDeleteAllToggled);
		}
	}
}
