using System;
using System.Collections.Generic;
using Gtk;

namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class NarucivanjeWidget : Gtk.Bin
	{
		public NarucivanjeWidget()
		{
			this.Build();

			buttonSpremi.Clicked += spremi;

			List<Hrana> listaHrana = BPHrana.DohvatiUmak();

			foreach (var i in listaHrana)
			{
				CheckButton temp = new CheckButton();
				temp.Label = i.Naziv + " " + i.Cijena + " kn";
				 
				vboxUmak.Add(temp);
			}

			listaHrana = BPHrana.DohvatiMeso();

			foreach (var i in listaHrana)
			{
				CheckButton temp = new CheckButton();
				temp.Label = i.Naziv + " " + i.Cijena + " kn";

				vboxMeso.Add(temp);
			}

			listaHrana = BPHrana.DohvatiSir();

			foreach (var i in listaHrana)
			{
				CheckButton temp = new CheckButton();
				temp.Label = i.Naziv + " " + i.Cijena + " kn";

				vboxSir.Add(temp);
			}

			listaHrana = BPHrana.DohvatiPrilozi();

			foreach (var i in listaHrana)
			{
				CheckButton temp = new CheckButton();
				temp.Label = i.Naziv + " " + i.Cijena + " kn";

				vboxPrilozi.Add(temp);
			}


		}

		protected void spremi(object sender, EventArgs a)
		{
			Narudzba temp = new Narudzba();

			if (radiobutton1.Active == true)
			{
				temp.Opis = radiobutton1.Label + " (";
				temp.Iznos = 20;
			}
			else if (radiobutton2.Active == true)
			{
				temp.Opis = radiobutton1.Label + " (";
				temp.Iznos = 5;
			}
			else if (radiobutton3.Active == true)
			{ 
				temp.Opis = radiobutton3.Label + " (";
				temp.Iznos = 10;
			}
				

			Widget[] polje = vboxUmak.Children;
			CheckButton button;

			foreach (var i in polje)
			{
				button = (CheckButton)i;
				if (button.Active == true)
				{
					string naziv = button.Label;
					naziv = naziv.Substring(0, naziv.Length - 5);
					naziv = naziv.Trim();

					double iznos = BPHrana.Cijena("Umak", naziv);

					temp.Iznos += iznos;

					temp.Opis += button.Label + ", ";
				}
			}

			polje = vboxMeso.Children;

			foreach (var i in polje)
			{
				button = (CheckButton)i;
				if (button.Active == true)
				{
					string naziv = button.Label;
					naziv = naziv.Substring(0, naziv.Length - 5);
					naziv = naziv.Trim();

					double iznos = BPHrana.Cijena("Meso", naziv);

					temp.Iznos += iznos;

					temp.Opis += button.Label + ", ";
				}
			}

			polje = vboxSir.Children;

			foreach (var i in polje)
			{
				button = (CheckButton)i;
				if (button.Active == true)
				{
					string naziv = button.Label;
					naziv = naziv.Substring(0, naziv.Length - 5);
					naziv = naziv.Trim();

					double iznos = BPHrana.Cijena("Sir", naziv);

					temp.Iznos += iznos;

					temp.Opis += button.Label + ", ";
				}
			}

			polje = vboxPrilozi.Children;

			foreach (var i in polje)
			{
				button = (CheckButton)i;
				if (button.Active == true)
				{
					string naziv = button.Label;
					naziv = naziv.Substring(0, naziv.Length - 5);
					naziv = naziv.Trim();

					double iznos = BPHrana.Cijena("Prilozi", naziv);

					temp.Iznos += iznos;

					temp.Opis += button.Label + ", ";
				}
			}

			temp.Opis = temp.Opis.Substring(0, temp.Opis.Length - 2);

			temp.Opis += ")";

			BPNarudzba.Spremi(temp);

		}

		public Button dohvatiSpremi()
		{
			return buttonSpremi;
		}
	}
}
