using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SIMS_project.Korisnici
{
    internal class KorisnikRepository
    {
        public static List<Korisnik> korisnici;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;
        
        public KorisnikRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            KorisnikJSONReferenceConverter.Repo = this;
            korisnici = JsonConvert.DeserializeObject<List<Korisnik>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(Korisnik korisnik)
        {
            korisnik.Id = korisnici.Count;
            korisnici.Add(korisnik);
        }

        public Korisnik GetById(int id)
        {
            return korisnici.First(n => n.Id == id);
        }

        public List<Korisnik> GetAll()
        {
            return korisnici.Where(n => !n.Obrisan).ToList();
        }

        public void Remove(Korisnik korisnik)
        {
            korisnik.Obrisan = true;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(korisnici, Formatting.Indented, podesavanja));
        }

        
    }
}
