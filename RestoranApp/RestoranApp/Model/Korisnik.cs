using System;
namespace RestoranApp
{
	public class Korisnik
	{
		private long id;
		private string ime;
		private string prezime;
		private string kontaktBroj;
		private string adresa;
		private string email;
		private string lozinka;
		private long admin;

		public Korisnik()
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

		public string Ime
		{
			get
			{
				return ime;
			}

			set
			{
				ime = value;
			}
		}

		public string Prezime
		{
			get
			{
				return prezime;
			}

			set
			{
				prezime = value;
			}
		}

		public string KontaktBroj
		{
			get
			{
				return kontaktBroj;
			}

			set
			{
				kontaktBroj = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				email = value;
			}
		}

		public string Lozinka
		{
			get
			{
				return lozinka;
			}

			set
			{
				lozinka = value;
			}
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

		public long Admin
		{
			get
			{
				return admin;
			}

			set
			{
				admin = value;
			}
		}
	}
}
