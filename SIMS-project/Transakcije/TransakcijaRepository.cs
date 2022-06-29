using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SIMS_project.Transakcije
{
    internal class TransakcijaRepository
    {
        public static List<Transakcija> transakcije;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;

        public TransakcijaRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            TransakcijaJSONReferenceConverter.Repo = this;
            transakcije = JsonConvert.DeserializeObject<List<Transakcija>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(Transakcija stanica)
        {
            stanica.Id = transakcije.Count > 0 ? transakcije.Last().Id + 1 : 0;
            transakcije.Add(stanica);
        }

        public Transakcija GetById(int id)
        {
            return transakcije.First(n => n.Id == id);
        }

        public void Update(Transakcija stanica)
        {
            var result = from s in transakcije where s.Id == stanica.Id select s;

            result.First().ValueRSD = stanica.ValueRSD;
            result.First().VremeUlaska = stanica.VremeUlaska;
            result.First().TipVozila = stanica.TipVozila;
            result.First().Iznos = stanica.Iznos;
            result.First().BrojTablica = stanica.BrojTablica;
            result.First().VremeIzlaska = stanica.VremeIzlaska;
            result.First().Id = stanica.Id;
            result.First().MestoUlaska = stanica.MestoUlaska;
            result.First().MestoIzlaska = stanica.MestoIzlaska; 
            result.First().StanicaIzlaska = stanica.StanicaIzlaska;

            Save();
        }

        public List<Transakcija> GetAll()
        {
            return transakcije.ToList();
        }

        public List<Transakcija> GetForStation(int id) {
            List<Transakcija> transakcijeZaStanicu = new List<Transakcija>();
            foreach (Transakcija transakcija in transakcije.ToList()){
                if (transakcija.StanicaIzlaska.Id == id) transakcijeZaStanicu.Add(transakcija);
            }
            return transakcijeZaStanicu;
        }

        public void Remove(Transakcija stanica)
        {
            transakcije.Remove(stanica);
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(transakcije, Formatting.Indented, podesavanja));
        }


    }
}
