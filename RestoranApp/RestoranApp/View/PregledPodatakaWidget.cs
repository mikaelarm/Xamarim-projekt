using System;
using Gtk;

namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PregledPodatakaWidget : Gtk.Bin
	{
		public PregledPodatakaWidget()
		{
			this.Build();

			buttonSpremi.Clicked += spremi;
		}

		protected void spremi(object sender, EventArgs a)
		{
			if (entryUlica.Text == "" || entryKontakt.Text == "")
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Adresa i kontak moraju biti uneseni!");

				d.Run();
				d.Destroy();
				return;
			}

			AdresaDostave temp = new AdresaDostave();
			temp.Adresa = entryUlica.Text;
			temp.Broj = entryKontakt.Text;

			BPAdresaDostave.Spremi(temp);

			Toplevel.Destroy();
		}

		public void osvjezi()
		{
			entryUlica.Text = Globalna.trenutni.Adresa;
			entryKontakt.Text = Globalna.trenutni.KontaktBroj.ToString();
		}
	}
}
