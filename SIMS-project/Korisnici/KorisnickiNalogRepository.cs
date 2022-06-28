using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SIMS_project.Korisnici
{
    public class InvalidLoginAttemptException : Exception
    {
        public InvalidLoginAttemptException(string errorMessage) : base($"Neuspesno logovanje: {errorMessage}.")
        {

        }
    }
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

        public KorisnickiNalog AttemptLogin(string korisnickoIme, string lozinka)
        {
            foreach (KorisnickiNalog kn in GetAll())
            {
                if (kn.KorisnickoIme == korisnickoIme && kn.Lozinka == lozinka)
                {
                    return kn;
                }
            }

            throw new InvalidLoginAttemptException("Neispravni kreencijali");
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

        public List<KorisnickiNalog> GetByUsername(string korisnickoIme)
        {
            return GetAll().Where(n => n.KorisnickoIme == korisnickoIme).ToList();
        }
    }
}
