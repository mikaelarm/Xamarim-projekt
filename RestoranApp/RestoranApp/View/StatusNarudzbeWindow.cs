using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	public partial class StatusNarudzbeWindow : Gtk.Window
	{
		public NarudzbaNodeStore nPresenter = new NarudzbaNodeStore();

		public StatusNarudzbeWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			nodeview1.NodeStore = nPresenter;

			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Iznos", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Status", new CellRendererText(), "text", 2);

			List<Narudzba> lista = BPNarudzba.DohvatiSve();

			foreach (var i in lista)
			{
				nPresenter.DodajNarudzbu(i, null);
			}
		}
	}
}
