using System;
namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class NarudzbaWidget : Gtk.Bin
	{
		public NarudzbaWidget()
		{
			this.Build();

			buttonNaruci.Clicked += naruci;
			buttonStatus.Clicked += status;
			buttonCjenik.Clicked += cjenik;
		}

		protected void naruci(object sender, EventArgs a)
		{
			var windowNaruci = new NarucivanjeWindow();
		}

		protected void status(object sender, EventArgs a)
		{
			var windowStatus = new StatusNarudzbeWindow();
		}

		protected void cjenik(object sender, EventArgs a)
		{
			var windowCjenik = new CjenikWindow();
		}
	}
}
