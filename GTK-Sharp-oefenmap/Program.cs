using System;
using Gtk;

namespace GTKSharpoefenmap
{
	class MainClass
	{
		static Widget xpm_label_box(string xpm_filename, string label_text)
		{
			HBox box = new HBox (false, 0);
			box.BorderWidth = 2;

			Gtk.Image image = new Gtk.Image (xpm_filename);

			Label label = new Label (label_text);

			box.PackStart (image, false, false, 3);
			box.PackStart (label, false, false, 3);

			image.Show ();
			label.Show ();

			return box;
		}

		static void callback(object obj,EventArgs args)
		{
			Console.WriteLine ("Hello again - cool button was pressed");
		}

		static void delete_event (object obj, DeleteEventArgs args)
		{
			Application.Quit ();
		}

		public static void Main (string[] args)
		{
			Application.Init ();
			Window window = new Window ("Pixmap´d Buttons");
			window.DeleteEvent += delete_event;

			window.BorderWidth = 10;
			Button button = new Button ();

			button.Clicked += callback;

			Widget box = xpm_label_box ("info.xpm", "cool button");

			box.Show ();
			button.Add (box);
			button.Show ();
			window.Add (button);
			window.ShowAll ();
			Application.Run ();
		}
	}
}
