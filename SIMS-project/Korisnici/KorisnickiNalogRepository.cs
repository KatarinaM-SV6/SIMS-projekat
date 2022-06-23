using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SIMS_project.Korisnici
{
    internal class KorisnickiNalogRepository
    {
        public static List<KorisnickiNalog> korisnickiNalozi;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;
        
        public KorisnickiNalogRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            KorisnickiNalogJSONReferenceConverter.Repo = this;
            korisnickiNalozi = JsonConvert.DeserializeObject<List<KorisnickiNalog>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(KorisnickiNalog nalog)
        {
            nalog.Id = korisnickiNalozi.Count > 0 ? korisnickiNalozi.Last().Id + 1 : 0;
            korisnickiNalozi.Add(nalog);
        }

        public KorisnickiNalog GetById(int id)
        {
            return korisnickiNalozi.First(n => n.Id == id);
        }

        public List<KorisnickiNalog> GetAll()
        {
            return korisnickiNalozi.Where(n => !n.Obrisan).ToList();
        }

        public void Remove(KorisnickiNalog nalog)
        {
            nalog.Obrisan = true;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(korisnickiNalozi, Formatting.Indented, podesavanja));
        }

        
    }
}
