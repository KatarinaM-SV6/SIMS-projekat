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
		int _id;
		DateTime _datum;
		Uredjaj _uredjaj;
		string _opisKvara;
		bool _obustsaviRadMesta;
		KorisnickiNalog _prijavio;
		bool _obradjena;

		public DojavaOKvaru()
		{
		}

		public DojavaOKvaru(int id, DateTime datum, Uredjaj uredjaj, string opisKvara, bool obustsaviRadMesta, KorisnickiNalog prijavio, bool obradjena)
		{
			_datum = datum;
			_uredjaj = uredjaj;
			_opisKvara = opisKvara;
			_obustsaviRadMesta = obustsaviRadMesta;
			_prijavio = prijavio;
			_obradjena = obradjena;
		}

        public int Id { get => _id; set => _id = value; }
		public DateTime Datum { get => _datum; set => _datum = value; }
        public Uredjaj Uredjaj { get => _uredjaj; set => _uredjaj = value; }
		public string OpisKvara { get => _opisKvara; set => _opisKvara = value; }
		public bool ObustsaviRadMesta { get => _obustsaviRadMesta; set => _obustsaviRadMesta = value; }
		public KorisnickiNalog Prijavio { get => _prijavio; set => _prijavio = value; }
        public bool Obradjena { get => _obradjena; set => _obradjena = value; }
    }
}
