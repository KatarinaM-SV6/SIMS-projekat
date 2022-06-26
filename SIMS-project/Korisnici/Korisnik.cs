using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIMS_project.NaplatneStanice;

namespace SIMS_project.Korisnici
{
	public class Korisnik
	{
		int _id = -1;
		string _ime;
		string _prezime;
		NaplatnaStanica _radnoMesto;
		KorisnickiNalog _korisnickiNalog;
		bool _obrisan;

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
		public int Id { get => _id; set => _id = value; }
        public bool Obrisan { get => _obrisan; set => _obrisan = value; }
		//[JsonConverter(typeof(PersonJSONReferenceConverter))]
		[JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
		internal NaplatnaStanica RadnoMesto { get => _radnoMesto; set => _radnoMesto = value; }
		[JsonConverter(typeof(KorisnickiNalogJSONReferenceConverter))]
		internal KorisnickiNalog KorisnickiNalog { get => _korisnickiNalog; set => _korisnickiNalog = value; }

		public override string ToString()
        {
			return $"Korisnik [ Id = {Id}, Ime = {Ime}, Prezime = {Prezime}]";
        }
	}
}
