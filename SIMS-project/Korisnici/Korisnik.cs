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
		bool _obrisan;

		public Korisnik()
		{
		}

		public Korisnik(string ime, string prezime, KorisnickiNalog korisnickiNalog, NaplatnaStanica radnoMesto)
		{
			_ime = ime;
			_prezime = prezime;
			_radnoMesto = radnoMesto;
		}


		public string Ime { get => _ime; set => _ime = value; }
		public string Prezime { get => _prezime; set => _prezime = value; }
		public int Id { get => _id; set => _id = value; }
        public bool Obrisan { get => _obrisan; set => _obrisan = value; }
		//[JsonConverter(typeof(PersonJSONReferenceConverter))]
		[JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
		public NaplatnaStanica RadnoMesto { get => _radnoMesto; set => _radnoMesto = value; }
	
		public override string ToString()
        {
			return $"{Ime} {Prezime}";
        }
	}
}
