using System;
namespace RestoranApp
{
	public class AdresaDostave
	{
		private string adresa;
		private string broj;

		public AdresaDostave()
		{
		}

		public string Adresa
		{
			get
			{
				return adresa;
			}

			set
			{
				adresa = value;
			}
		}

		public string Broj
		{
			get
			{
				return broj;
			}

			set
			{
				broj = value;
			}
		}
	}
}
