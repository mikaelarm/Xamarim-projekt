using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	public partial class IzmjenaStatusaWindow : Gtk.Window
	{
		NarudzbaNodeStore presenter = new NarudzbaNodeStore();

		public string pok;

		public IzmjenaStatusaWindow(string status) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			pok = status;

			buttonSpremi.Clicked += spremi;
			buttonIzbrisi.Clicked += izbrisi;

			nodeview1.NodeStore = presenter;

			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Iznos", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Adresa", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Kontakt", new CellRendererText(), "text", 4);

			osvjezi();
		}

		protected void spremi(object sender, EventArgs a)
		{
			NarudzbaNode narudzbaSelected = nodeview1.NodeSelection.SelectedNode as NarudzbaNode;
			if (narudzbaSelected == null)
				return;

			BPNarudzba.Uredi(narudzbaSelected.id, combobox.ActiveText);

			osvjezi();
		}

		protected void izbrisi(object sender, EventArgs a)
		{
			NarudzbaNode narudzbaSelected = nodeview1.NodeSelection.SelectedNode as NarudzbaNode;
			if (narudzbaSelected == null)
				return;

			Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, "Sigurno želite obrisati narudzbu?");

			ResponseType response = (ResponseType) d.Run();
			d.Destroy();

			if(response == ResponseType.Yes)
			{
				BPNarudzba.Izbrisi(narudzbaSelected.id);
				osvjezi();
				return;
			}
			else
				return;
		}

		protected void osvjezi()
		{
			presenter.Clear();

			List<Narudzba> listaNaruzdbi = BPNarudzba.Dohvati(pok);

			foreach (var i in listaNaruzdbi)
			{
				AdresaDostave temp = BPAdresaDostave.Dohvati(i.Id_k);
				presenter.DodajNarudzbu(i, temp);
			}
		}
	}
}
