using System;
namespace RestoranApp
{
	public class Hrana
	{
		private long id;
		private string naziv;
		private double cijena;

		public Hrana()
		{
		}

		public long Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}

		public string Naziv
		{
			get
			{
				return naziv;
			}

			set
			{
				naziv = value;
			}
		}

		public double Cijena
		{
			get
			{
				return cijena;
			}

			set
			{
				cijena = value;
			}
		}
	}
}
