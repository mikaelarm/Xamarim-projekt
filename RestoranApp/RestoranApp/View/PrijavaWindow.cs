using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	public partial class PrijavaWindow : Gtk.Window
	{
		public PrijavaWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonPrijava.Clicked += prijava;
		}

		protected void prijava(object sender, EventArgs a)
		{
			if (entryMail.Text == "" || entryLozinka.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			List<Korisnik> listaKorisnika = BPKorisnik.DohvatiSve();

			bool flag = false;

			foreach (var i in listaKorisnika)
			{
				if (entryMail.Text == i.Email && entryLozinka.Text == i.Lozinka)
				{
					Globalna.trenutni = i;
					flag = true;
					break;
				}
			}

			if (!flag)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Neispravan email ili lozinka");

				d.Run();
				d.Destroy();
				return;
			}

			Destroy();
		}
	}
}
