using System;
namespace RestoranApp
{
	public class Narudzba
	{
		private long id;
		private string opis;
		private double iznos;
		private string status;
		private long id_k;

		public Narudzba()
		{
			status = "zaprimljeno";
			iznos = 0;
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

		public string Opis
		{
			get
			{
				return opis;
			}

			set
			{
				opis = value;
			}
		}

		public double Iznos
		{
			get
			{
				return iznos;
			}

			set
			{
				iznos = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}

			set
			{
				status = value;
			}
		}

		public long Id_k
		{
			get
			{
				return id_k;
			}

			set
			{
				id_k = value;
			}
		}
	}
}
