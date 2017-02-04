using System;
using Gtk;

namespace RestoranApp
{
	public partial class NarucivanjeWindow : Gtk.Window
	{
		public NarucivanjeWidget narucivanje = new NarucivanjeWidget();
		public OdabranoPopisWidget odabrano = new OdabranoPopisWidget();
		public PregledPodatakaWidget pregled = new PregledPodatakaWidget();

		public VBox mainBox;

		public NarucivanjeWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Button buttonSpremi = narucivanje.dohvatiSpremi();
			Button buttonNaruci = odabrano.dohvatiNaruciJos();
			Button buttonGotovo = odabrano.dohvatiGotovo();

			buttonSpremi.Clicked += spremi;
			buttonNaruci.Clicked += naruci;
			buttonGotovo.Clicked += gotovo;

			mainBox = vboxMain;

			mainBox.Add(narucivanje);

			Build();
		}

		protected void spremi(object sender, EventArgs a)
		{
			mainBox.Remove(narucivanje);
			mainBox.Remove(pregled);
			mainBox.Add(odabrano);

			odabrano.osvjezi();

			Build();
		}

		protected void naruci(object sender, EventArgs a)
		{
			mainBox.Remove(odabrano);
			mainBox.Remove(pregled);
			mainBox.Add(narucivanje);

			Build();
		}

		protected void gotovo(object sender, EventArgs a)
		{
			mainBox.Remove(odabrano);
			mainBox.Remove(narucivanje);
			mainBox.Add(pregled);

			pregled.osvjezi();

			Build();
		}
	}
}
