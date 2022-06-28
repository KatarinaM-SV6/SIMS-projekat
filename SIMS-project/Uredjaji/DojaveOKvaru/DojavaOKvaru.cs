using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIMS_project.Korisnici;
using SIMS_project.NaplatneStanice;

namespace SIMS_project.Uredjaji.DojaveOKvaru
{
	class DojavaOKvaru
	{
		int _id;
		DateTime _datum;
		Uredjaj _uredjaj;
		string _opisKvara;
		bool _obustaviRadMesta;
		bool _obradjena;
		NaplatnaStanica _naplatnaStanica;

		public DojavaOKvaru()
		{
		}

		public DojavaOKvaru(int id, DateTime datum, Uredjaj uredjaj, string opisKvara, bool obustaviRadMesta,  bool obradjena, NaplatnaStanica naplatnaStanica)
		{
			_id = id;
			_datum = datum;
			Uredjaj = uredjaj;
			_opisKvara = opisKvara;
			_obustaviRadMesta = obustaviRadMesta;
			_obradjena = obradjena;
			_naplatnaStanica = naplatnaStanica;
		}

		public DojavaOKvaru(DateTime datum, Uredjaj uredjaj, string opisKvara, bool obustaviRadMesta, NaplatnaStanica naplatnaStanica)
		{
			_datum = datum;
			Uredjaj = uredjaj;
			_opisKvara = opisKvara;
			_obustaviRadMesta = obustaviRadMesta;
			_obradjena = false;
			_naplatnaStanica = naplatnaStanica;
		}

		public DojavaOKvaru(DateTime datum, Uredjaj uredjaj, string opisKvara, bool obustaviRadMesta, bool obradjena, NaplatnaStanica naplatnaStanica)
		{
			_datum = datum;
			Uredjaj = uredjaj;
			_opisKvara = opisKvara;
			_obustaviRadMesta = obustaviRadMesta;
			_obradjena = obradjena;
			_naplatnaStanica = naplatnaStanica;
		}

		public int Id { get => _id; set => _id = value; }
		public DateTime Datum { get => _datum; set => _datum = value; }
		public string OpisKvara { get => _opisKvara; set => _opisKvara = value; }
		public bool ObustsaviRadMesta { get => _obustaviRadMesta; set => _obustaviRadMesta = value; }
        public bool Obradjena { get => _obradjena; set => _obradjena = value; }
		[JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
		public NaplatnaStanica NaplatnaStanica { get => _naplatnaStanica; set => _naplatnaStanica = value; }
        public Uredjaj Uredjaj { get => _uredjaj; set => _uredjaj = value; }
    }
}
