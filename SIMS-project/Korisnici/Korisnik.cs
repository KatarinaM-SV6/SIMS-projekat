using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS_project.NaplatneStanice;

namespace SIMS_project.Korisnici
{
	class Korisnik
	{
		string _ime;
		string _prezime;
		NaplatnaStanica _radnoMesto;
		KorisnickiNalog _korisnickiNalog;

		public Korisnik()
		{
		}

		public Korisnik(string ime, string prezime, KorisnickiNalog korisnickiNalog = null, NaplatnaStanica radnoMesto=null)
		{
			_ime = ime;
			_prezime = prezime;
			_radnoMesto = radnoMesto;
			_korisnickiNalog = korisnickiNalog;
		}

		public string Ime { get => _ime; set => _ime = value; }
		public string Prezime { get => _prezime; set => _prezime = value; }
		internal NaplatnaStanica RadnoMesto { get => _radnoMesto; set => _radnoMesto = value; }
		internal KorisnickiNalog KorisnickiNalog { get => _korisnickiNalog; set => _korisnickiNalog = value; }
	}
}
