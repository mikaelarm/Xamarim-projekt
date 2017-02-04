using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace RestoranApp
{
	public static class BPKorisnik
	{
		public static void Spremi(Korisnik k)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into korisnik (ime, prezime, kontakt_broj, adresa, email, lozinka, admin) Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
			                                    k.Ime, k.Prezime, k.KontaktBroj, k.Adresa, k.Email, k.Lozinka, 0);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static List<Korisnik> DohvatiSve()
		{
			List<Korisnik> listaKorisnika = new List<Korisnik>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from korisnik";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Korisnik k = new Korisnik();

				k.Id = (int)(Int64)reader["id"];
				k.Ime = (string)reader["ime"];
				k.Prezime = (string)reader["prezime"];
				k.KontaktBroj = (string)reader["kontakt_broj"];
				k.Adresa = (string)reader["adresa"];
				k.Email = (string)reader["email"];
				k.Lozinka = (string)reader["lozinka"];
				k.Admin = (int)(Int64)reader["admin"];

				listaKorisnika.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKorisnika;
		}
	}
}
