using System;
using System.Collections.Generic;

namespace RestoranApp
{
	public class NarudzbaNodeStore : Gtk.NodeStore
	{
		public NarudzbaNodeStore() : base(typeof(NarudzbaNode))
		{
		}

		public void DodajNarudzbu(Narudzba n, AdresaDostave a)
		{
			NarudzbaNode temp = new NarudzbaNode(n, a);
			this.AddNode(temp);
		}
	}
}
