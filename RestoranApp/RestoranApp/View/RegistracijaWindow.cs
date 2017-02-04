using System;
using Gtk;

namespace RestoranApp
{
	public partial class RegistracijaWindow : Gtk.Window
	{
		public RegistracijaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonPosalji.Clicked += posalji;
		}

		protected void posalji(object sender, EventArgs a)
		{
			if (entryIme.Text == "" || entryPrezime.Text == "" || entryAdresa.Text == "" || entryBroj.Text == "" || entryEmail.Text == ""
			   || entryLozinka.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			Korisnik temp = new Korisnik();

			temp.Ime = entryIme.Text;
			temp.Prezime = entryPrezime.Text;
			temp.Adresa = entryAdresa.Text;
			temp.KontaktBroj = entryBroj.Text;
			temp.Email = entryEmail.Text;
			temp.Lozinka = entryLozinka.Text;

			BPKorisnik.Spremi(temp);

			this.Destroy();
		}
	}
}
