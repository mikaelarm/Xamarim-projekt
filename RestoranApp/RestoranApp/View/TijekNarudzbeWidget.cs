using System;
namespace RestoranApp
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class TijekNarudzbeWidget : Gtk.Bin
	{
		public TijekNarudzbeWidget()
		{
			this.Build();

			buttonZaprimljeno.Clicked += zaprimljeno;
			buttonPriprema.Clicked += priprema;
			buttonDostava.Clicked += dostava;
			buttonIzvrseno.Clicked += zavrseno;
		}

		protected void zaprimljeno(object sender, EventArgs a)
		{
			var window = new IzmjenaStatusaWindow("zaprimljeno");
		}

		protected void priprema(object sender, EventArgs a)
		{
			var window = new IzmjenaStatusaWindow("priprema");
		}

		protected void dostava(object sender, EventArgs a)
		{
			var window = new IzmjenaStatusaWindow("dostava");
		}

		protected void zavrseno(object sender, EventArgs a)
		{
			var window = new IzmjenaStatusaWindow("izvršeno");
		}
	}
}
