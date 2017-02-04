using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class OdabranoPopisWidget : Gtk.Bin
	{
		public NarudzbaNodeStore nPresenter = new NarudzbaNodeStore();

		public OdabranoPopisWidget()
		{
			this.Build();

			nodeview1.NodeStore = nPresenter;

			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Iznos", new CellRendererText(), "text", 1);
		}

		public void osvjezi()
		{ 
			List<Narudzba> lista = BPNarudzba.DohvatiSve();

			Double suma = 0;

			nPresenter.Clear();

			foreach (var i in lista)
			{
				if (i.Status == "zaprimljeno")
				{
					nPresenter.DodajNarudzbu(i, null);
					suma += i.Iznos;
				}
			}

			labelUkupnaCijena.Text = suma.ToString();
		}

		public Button dohvatiNaruciJos()
		{
			return buttonNaruci;
		}

		public Button dohvatiGotovo()
		{
			return buttonGotovo;
		}
	}
}
