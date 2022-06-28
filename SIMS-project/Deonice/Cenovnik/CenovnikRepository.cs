using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice.Cenovnik
{
    class CenovnikRepository
    {
        private static List<Cenovnik> cenovnici;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;

        public CenovnikRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            CenovnikJSONReferenceConverter.Repo = this;
            cenovnici = JsonConvert.DeserializeObject<List<Cenovnik>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(Cenovnik cenovnik)
        {
            cenovnik.Id = cenovnici.Count > 0 ? cenovnici.Last().Id + 1 : 0;
            cenovnici.Add(cenovnik);
        }

        public Cenovnik GetById(int id)
        {
            return cenovnici.First(n => n.Id == id);
        }

        public List<Cenovnik> GetAll()
        {
            return cenovnici;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(cenovnici, Formatting.Indented, podesavanja));
        }

    }
}
