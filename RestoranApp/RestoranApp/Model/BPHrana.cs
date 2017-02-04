using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace RestoranApp
{
	public static class BPHrana
	{
		public static List<Hrana> DohvatiMeso()
		{
			List<Hrana> listaHrane = new List<Hrana>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from meso";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Hrana h = new Hrana();

				h.Id = (int)(Int64)reader["id"];
				h.Naziv = (string)reader["naziv"];
				h.Cijena = (Double)reader["cijena"];

				listaHrane.Add(h);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaHrane;
		}

		public static List<Hrana> DohvatiPrilozi()
		{
			List<Hrana> listaHrane = new List<Hrana>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from prilozi";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Hrana h = new Hrana();

				h.Id = (int)(Int64)reader["id"];
				h.Naziv = (string)reader["naziv"];
				h.Cijena = (Double)reader["cijena"];

				listaHrane.Add(h);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaHrane;
		}

		public static List<Hrana> DohvatiSir()
		{
			List<Hrana> listaHrane = new List<Hrana>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from sir";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Hrana h = new Hrana();

				h.Id = (int)(Int64)reader["id"];
				h.Naziv = (string)reader["naziv"];
				h.Cijena = (Double)reader["cijena"];

				listaHrane.Add(h);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaHrane;
		}

		public static List<Hrana> DohvatiUmak()
		{
			List<Hrana> listaHrane = new List<Hrana>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from umak";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Hrana h = new Hrana();

				h.Id = (int)(Int64)reader["id"];
				h.Naziv = (string)reader["naziv"];
				h.Cijena = (Double)reader["cijena"];

				listaHrane.Add(h);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaHrane;
		}

		public static double Cijena(string hrana, string naziv)
		{
			List<Hrana> listaHrane = new List<Hrana>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from '{0}' where naziv = '{1}'", hrana, naziv);

			SqliteDataReader reader = command.ExecuteReader();

			double cijena = 0;

			while (reader.Read())
			{
				cijena = (Double)reader["cijena"];
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return cijena;
		}
	}
}
