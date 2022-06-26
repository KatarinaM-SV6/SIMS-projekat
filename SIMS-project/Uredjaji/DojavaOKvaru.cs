using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS_project.Korisnici;

namespace SIMS_project.Uredjaji
{
	class DojavaOKvaru
	{
		DateTime _datum;
		string _opisKvara;
		bool _obustsaviRadMesta;
		KorisnickiNalog _prijavio;
		Uredjaj _uredjaj;

		public DojavaOKvaru()
		{
		}

		public DojavaOKvaru(DateTime datum, string opisKvara, bool obustsaviRadMesta, KorisnickiNalog prijavio, Uredjaj uredjaj)
		{
			_datum = datum;
			_opisKvara = opisKvara;
			_obustsaviRadMesta = obustsaviRadMesta;
			_prijavio = prijavio;
			_uredjaj = uredjaj;
		}

		public DateTime Datum { get => _datum; set => _datum = value; }
		public string OpisKvara { get => _opisKvara; set => _opisKvara = value; }
		public bool ObustsaviRadMesta { get => _obustsaviRadMesta; set => _obustsaviRadMesta = value; }
		public KorisnickiNalog Prijavio { get => _prijavio; set => _prijavio = value; }
		public Uredjaj Uredjaj { get => _uredjaj; set => _uredjaj = value; }
	}
}
