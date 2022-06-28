using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SIMS_project.NaplatneStanice;

namespace SIMS_project.Transakcije
{
	public enum TipVozila { 
		Ia,
		I,
		II,
		III,
		IV
	}
	class Transakcija
	{
		bool _valueRSD;
		DateTime _vremeUlaska;
		TipVozila _tipVozila;
		float _iznos;
		string _brojTablica;
		DateTime _vremeIzlaska;
		int _idTaga;
		NaplatnoMesto _mestoUlaska;
		NaplatnoMesto _mestoIzlaska;
		NaplatnaStanica _stanicaIzlaska;

		public Transakcija(bool valueRSD, DateTime vremeUlaska, TipVozila tipVozila, float iznos, string brojTablica, DateTime vremeIzlaska, int idTaga, NaplatnoMesto mestoUlaska, NaplatnoMesto mestoIzlaska, NaplatnaStanica naplatnaStanica)
		{
			_valueRSD = valueRSD;
			_vremeUlaska = vremeUlaska;
			_tipVozila = tipVozila;
			_iznos = iznos;
			_brojTablica = brojTablica;
			_vremeIzlaska = vremeIzlaska;
			_idTaga = idTaga;
			_mestoUlaska = mestoUlaska;
			_mestoIzlaska = mestoIzlaska;
			_stanicaIzlaska = naplatnaStanica;
		}

		Transakcija() { }

		public bool ValueRSD { get => _valueRSD; set => _valueRSD = value; }
		public DateTime VremeUlaska { get => _vremeUlaska; set => _vremeUlaska = value; }
		[JsonConverter(typeof(StringEnumConverter))]
		public TipVozila TipVozila { get => _tipVozila; set => _tipVozila = value; }
		public float Iznos { get => _iznos; set => _iznos = value; }
		public string BrojTablica { get => _brojTablica; set => _brojTablica = value; }
		public DateTime VremeIzlaska { get => _vremeIzlaska; set => _vremeIzlaska = value; }
		public int Id { get => _idTaga; set => _idTaga = value; }
		[JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
		public NaplatnaStanica StanicaIzlaska { get => _stanicaIzlaska; set => _stanicaIzlaska = value; }
        internal NaplatnoMesto MestoUlaska { get => _mestoUlaska; set => _mestoUlaska = value; }
		internal NaplatnoMesto MestoIzlaska { get => _mestoIzlaska; set => _mestoIzlaska = value; }
	}
}
