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
		string _korisnickoIme;
		string _lozinka;
		TipKorisnika _tipKorisnika;
		Korisnik _korisnik;

		public KorisnickiNalog() { }

		public KorisnickiNalog(string korisnickoIme, string lozinka, TipKorisnika tipKorisnika, Korisnik korisnik)
		{
			_korisnickoIme = korisnickoIme;
			_lozinka = lozinka;
			_tipKorisnika = tipKorisnika;
			_korisnik = korisnik;
		}

		public string KorisnickoIme { get => _korisnickoIme; set => _korisnickoIme = value; }
		public string Lozinka { get => _lozinka; set => _lozinka = value; }
		public TipKorisnika TipKorisnika { get => _tipKorisnika; set => _tipKorisnika = value; }
		public Korisnik Korisnik { get => _korisnik; set => _korisnik = value; }
	}
}
