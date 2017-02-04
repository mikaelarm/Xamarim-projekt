using System;
using Gtk;
using RestoranApp;

public partial class MainWindow : Gtk.Window
{
	public PocetnaWidget pocetna = new PocetnaWidget();
	public NarudzbaWidget narudzba = new NarudzbaWidget();
	public TijekNarudzbeWidget tijek = new TijekNarudzbeWidget();
	public VBox mainBox;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		Button buttonPrijava = pocetna.dohvatiPrijava();
		Button buttonRegistracija = pocetna.dohvatiRegistracija();

		buttonPrijava.Clicked += otvoriPrijava;
		buttonRegistracija.Clicked += otvoriRegistracija;


		mainBox = vboxMain;
		mainBox.Add(pocetna);

		Build();
	}

	protected void otvoriPrijava(object sender, EventArgs a)
	{
		var windowPrijava = new PrijavaWindow();

		windowPrijava.Destroyed += otvoriNarudzba;
	}

	protected void otvoriRegistracija(object sender, EventArgs a)
	{
		var windowRegistracija = new RegistracijaWindow();
	}

	protected void otvoriNarudzba(object sender, EventArgs a)
	{
		mainBox.Remove(pocetna);

		if (Globalna.trenutni.Admin == 1)
		{
			mainBox.Add(tijek);
		}
		else
		{
			mainBox.Add(narudzba);
		}

		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
