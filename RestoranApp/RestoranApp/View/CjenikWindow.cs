using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	public partial class CjenikWindow : Gtk.Window
	{
		public CjenikWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			List<Hrana> listaHrana = BPHrana.DohvatiUmak();

			foreach (var i in listaHrana)
			{
				Label temp = new Label();
				temp.Text = i.Naziv + " " + i.Cijena + " kn";

				vboxUmak.Add(temp);
			}

			listaHrana = BPHrana.DohvatiMeso();

			foreach (var i in listaHrana)
			{
				Label temp = new Label();
				temp.Text = i.Naziv + " " + i.Cijena + " kn";

				vboxMeso.Add(temp);
			}

			listaHrana = BPHrana.DohvatiSir();

			foreach (var i in listaHrana)
			{
				Label temp = new Label();
				temp.Text = i.Naziv + " " + i.Cijena + " kn";

				vboxSir.Add(temp);
			}

			listaHrana = BPHrana.DohvatiPrilozi();

			foreach (var i in listaHrana)
			{
				Label temp = new Label();
				temp.Text = i.Naziv + " " + i.Cijena + " kn";

				vboxPrilozi.Add(temp);
			}

			Build();
		}
	}
}
