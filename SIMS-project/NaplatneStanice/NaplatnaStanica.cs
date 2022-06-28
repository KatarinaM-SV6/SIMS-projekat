using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIMS_project.Korisnici;

namespace SIMS_project.NaplatneStanice
{
    public class NaplatnaStanica
    {
        int _id = -1;
        Mesto _mesto;
        List<NaplatnoMesto> _naplatnaMesta;
        String _nazivAutoputa;
        bool _obrisana;
        List<Korisnik> _radnici;
        Korisnik _vodjaStanice;

        public NaplatnaStanica() { }
        
        public NaplatnaStanica(Mesto mesto, List<NaplatnoMesto> naplatnaMesta, String nazivAutoputa, List<Korisnik> radnici, Korisnik vodjaStanice)
        {
            _mesto = mesto;
            _naplatnaMesta = naplatnaMesta;
            _nazivAutoputa = nazivAutoputa;
            _radnici = radnici;
            _vodjaStanice = vodjaStanice;
        }

        public NaplatnaStanica(Mesto mesto, List<NaplatnoMesto> naplatnaMesta, String nazivAutoputa)
        {
            _mesto = mesto;
            _naplatnaMesta = naplatnaMesta;
            _nazivAutoputa = nazivAutoputa;
            _radnici = new List<Korisnik>();
            _vodjaStanice = null;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public Mesto Mesto { get { return _mesto; } set { _mesto = value; } }
        public List<NaplatnoMesto> NaplatnaMesta { get { return _naplatnaMesta;} set { _naplatnaMesta = value;} }
        public String NazivAutoputa { get { return _nazivAutoputa; } set { _nazivAutoputa = value; } }
        public bool Obrisana { get { return _obrisana;} set { _obrisana = value;} }
        [JsonConverter(typeof(KorisnikListJSONConverter))]
        public List<Korisnik> Radnici { get { return _radnici; } set { _radnici = value; } }
        [JsonConverter(typeof(KorisnikJSONReferenceConverter))]
        public Korisnik VodjaStanice { get { return _vodjaStanice;} set { _vodjaStanice = value;} }

        public override string ToString()
        {
            return "\nID: " + _id + ", Mesto: " + _mesto.Naziv + ", Naziv autoputa: " + _nazivAutoputa;
        }

        public void AddMesto(NaplatnoMesto mesto)
        {
            mesto.RedniBroj = NaplatnaMesta.Count > 0 ? NaplatnaMesta.Last().RedniBroj + 1 : 0;
            NaplatnaMesta.Add(mesto);
        }
    }
}
