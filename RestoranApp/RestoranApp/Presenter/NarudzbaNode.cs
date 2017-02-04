using System;
namespace RestoranApp
{
	public class NarudzbaNode : Gtk.TreeNode
	{
		public long id;
		public long idK;

		[Gtk.TreeNodeValue(Column = 0)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 1)]
		public String iznos;

		[Gtk.TreeNodeValue(Column = 2)]
		public String status;

		[Gtk.TreeNodeValue(Column = 3)]
		public String adresa;

		[Gtk.TreeNodeValue(Column = 4)]
		public String kontakt;

		public NarudzbaNode(Narudzba n, AdresaDostave a)
		{
			this.id = n.Id;
			this.idK = n.Id_k;

			this.opis = n.Opis;
			this.iznos = n.Iznos.ToString();
			this.status = n.Status;
			if (a != null)
			{
				this.adresa = a.Adresa;
				this.kontakt = a.Broj.ToString();
			}
		}
	}
}
