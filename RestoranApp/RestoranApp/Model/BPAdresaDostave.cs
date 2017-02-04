using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace RestoranApp
{
	public static class BPAdresaDostave
	{
		public static void Spremi(AdresaDostave a)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Replace into adresa_dostave (adresa, kontakt_broj, id_korisnik) Values ('{0}', '{1}', '{2}')",
			                                    a.Adresa, a.Broj, Globalna.trenutni.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static AdresaDostave Dohvati(long id)
		{
			AdresaDostave a = new AdresaDostave();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from adresa_dostave where id_korisnik = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				a.Adresa = (string)reader["adresa"];
				a.Broj = (string)reader["kontakt_broj"];
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return a;
		}
	}
}
