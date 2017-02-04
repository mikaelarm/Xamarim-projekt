using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace RestoranApp
{
	public static class BPNarudzba
	{
		public static void Spremi(Narudzba n)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into narudzba (opis, iznos, status, id_korisnik) Values ('{0}', '{1}', '{2}', '{3}')",
			                                    n.Opis, n.Iznos, n.Status, Globalna.trenutni.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(long id, string status)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Update narudzba set status = '{0}' where id = '{1}'", status, id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static List<Narudzba> DohvatiSve()
		{
			List<Narudzba> lista = new List<Narudzba>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from narudzba where id_korisnik = '{0}'", Globalna.trenutni.Id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Narudzba n = new Narudzba();

				n.Id_k = (int)(Int64)reader["id_korisnik"];
				n.Id = (int)(Int64)reader["id"];
				n.Opis = (string)reader["opis"];
				n.Iznos = (Double)reader["iznos"];
				n.Status = (string)reader["status"];

				lista.Add(n);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return lista;
		}

		public static List<Narudzba> Dohvati(string status)
		{
			List<Narudzba> lista = new List<Narudzba>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from narudzba where status = '{0}'", status);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Narudzba n = new Narudzba();

				n.Id_k = (int)(Int64)reader["id_korisnik"];
				n.Id = (int)(Int64)reader["id"];
				n.Opis = (string)reader["opis"];
				n.Iznos = (Double)reader["iznos"];
				n.Status = (string)reader["status"];

				lista.Add(n);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return lista;
		}

		public static void Izbrisi(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Delete from narudzba where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}
	}
}
