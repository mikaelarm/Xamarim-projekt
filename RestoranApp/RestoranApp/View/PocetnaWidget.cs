using System;
using Gtk;

namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PocetnaWidget : Gtk.Bin
	{
		public PocetnaWidget()
		{
			this.Build();
		}

		public Button dohvatiPrijava()
		{
			return buttonPrijava;
		}

		public Button dohvatiRegistracija()
		{
			return buttonRegistracija;
		}
	}
}
