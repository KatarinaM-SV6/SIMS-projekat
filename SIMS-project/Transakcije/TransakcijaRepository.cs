using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SIMS_project.Transakcije
{
    internal class TransakcijaRepository
    {
        public static List<Transakcija> transakcije;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;
        private static List<Transakcija> zapoceteTransakcije;


        public TransakcijaRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            TransakcijaJSONReferenceConverter.Repo = this;
            transakcije = JsonConvert.DeserializeObject<List<Transakcija>>(File.ReadAllText(fNaziv), podesavanja);
            ZapocniTransakcije();
        }

        public void Add(Transakcija stanica)
        {
            stanica.Id = transakcije.Count > 0 ? transakcije.Last().Id + 1  : 0;
            transakcije.Add(stanica);
        }

        public Transakcija GetById(int id)
        {
            return transakcije.First(n => n.Id == id);
        }

        public Transakcija GetByIdZapocete(int id)
        {
            return zapoceteTransakcije.First(n => n.Id == id);
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

        public void Remove(Transakcija stanica)
        {
            transakcije.Remove(stanica);
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(transakcije, Formatting.Indented, podesavanja));
        }

        public List<Transakcija> ZapoceteTransakcije { get => zapoceteTransakcije; set => zapoceteTransakcije = value; }
        
        public static void ZapocniTransakcije()
        {
            zapoceteTransakcije = new List<Transakcija>();
            Transakcija t = new Transakcija(DateTime.Now.AddMinutes(-45), "abcdef", Program.staniceRepo.GetById(1).NaplatnaMesta[0]);
            t.Id = transakcije.Count > 0 ? transakcije.Last().Id + 1 + zapoceteTransakcije.Count : 0;
            zapoceteTransakcije.Add(t);
            t = new Transakcija(DateTime.Now.AddMinutes(-60), "y123zzz", Program.staniceRepo.GetById(1).NaplatnaMesta[0]);
            t.Id = transakcije.Count > 0 ? transakcije.Last().Id + 1 + zapoceteTransakcije.Count : 0;
            zapoceteTransakcije.Add(t);
        }

        public string GetRandomTablice()
        {
            if (zapoceteTransakcije.Count > 0)
            {
                Random rd = new Random();
                int index = rd.Next(0, zapoceteTransakcije.Count);
                return zapoceteTransakcije[index].BrojTablica;
            }
            return "";
        }

    }
}
