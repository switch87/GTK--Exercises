using System;
using Gtk;

namespace GTKSharpoefenmap
{
	class MainClass
	{
		static Widget xpm_label_box(string xpm_filename, string label_text)
		{

			// Create box for image and label
			HBox box = new HBox (false, 0);
			box.BorderWidth = 2;

			// Including the image 
			Gtk.Image image = new Gtk.Image (xpm_filename);

			// Create label of button
			Label label = new Label (label_text);

			// packing the image and the label
			box.PackStart (image, false, false, 3);
			box.PackStart (label, false, false, 3);

			image.Show ();
			label.Show ();

			return box;
		}

		// callback function for clicking the button (works only in console!)
		static void callback(object obj,EventArgs args)
		{
			Console.WriteLine ("Hello again - cool button was pressed");
		}

		// collback for ending the program
		static void delete_event (object obj, DeleteEventArgs args)
		{
			Application.Quit ();
		}

		public static void Main (string[] args)
		{
			Application.Init ();

			// create window
			Window window = new Window ("Pixmap´d Buttons");

			// set event for ending the program
			window.DeleteEvent += delete_event;

			window.BorderWidth = 10;

			// creating the button
			Button button = new Button ();

			// click event
			button.Clicked += callback;

			// create box with label and image for inside button
			Widget box = xpm_label_box ("info.xpm", "cool button");
			box.Show ();

			// add box t button
			button.Add (box);
			button.Show ();

			// add button to window
			window.Add (button);

			// and show it all!
			window.ShowAll ();
			Application.Run ();
		}
	}
}
