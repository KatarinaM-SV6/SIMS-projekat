﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Korisnici
{
	public enum TipKorisnika { 
		PRODAVAC,
		ADMINISTRATOR,
		REFERENT,
		VODJA_STANICE
	}
	class KorisnickiNalog
	{
		int _id = -1;
		string _korisnickoIme;
		string _lozinka;
		TipKorisnika _tipKorisnika;
		Korisnik _korisnik;
		bool _obrisan;

		public KorisnickiNalog() { }

		public KorisnickiNalog(string korisnickoIme, string lozinka, TipKorisnika tipKorisnika, Korisnik korisnik)
		{
			_korisnickoIme = korisnickoIme;
			_lozinka = lozinka;
			_tipKorisnika = tipKorisnika;
			_korisnik = korisnik;
		}

        public int Id { get => _id; set => _id = value; }
		public string KorisnickoIme { get => _korisnickoIme; set => _korisnickoIme = value; }
		public string Lozinka { get => _lozinka; set => _lozinka = value; }
		public TipKorisnika TipKorisnika { get => _tipKorisnika; set => _tipKorisnika = value; }
		[JsonConverter(typeof(KorisnikJSONReferenceConverter))]
		public Korisnik Korisnik { get => _korisnik; set => _korisnik = value; }
        public bool Obrisan { get => _obrisan; set => _obrisan = value; }
    }
}
