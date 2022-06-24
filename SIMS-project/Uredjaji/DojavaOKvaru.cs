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

		public DojavaOKvaru()
		{
		}

		public DojavaOKvaru(DateTime datum, string opisKvara, bool obustsaviRadMesta, KorisnickiNalog prijavio)
		{
			_datum = datum;
			_opisKvara = opisKvara;
			_obustsaviRadMesta = obustsaviRadMesta;
			_prijavio = prijavio;
		}

		public DateTime Datum { get => _datum; set => _datum = value; }
		public string OpisKvara { get => _opisKvara; set => _opisKvara = value; }
		public bool ObustsaviRadMesta { get => _obustsaviRadMesta; set => _obustsaviRadMesta = value; }
		public KorisnickiNalog Prijavio { get => _prijavio; set => _prijavio = value; }
	}
}
