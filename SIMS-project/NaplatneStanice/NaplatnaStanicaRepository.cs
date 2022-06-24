using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SIMS_project.NaplatneStanice
{
    internal class NaplatnaStanicaRepository
    {
        public static List<NaplatnaStanica> naplatneStanice;
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;

        public NaplatnaStanicaRepository(string naziv, JsonSerializerSettings jPodesavanja)
        {
            fNaziv = naziv;
            podesavanja = jPodesavanja;
            NaplatnaStanicaJSONReferenceConverter.Repo = this;
            naplatneStanice = JsonConvert.DeserializeObject<List<NaplatnaStanica>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(NaplatnaStanica stanica)
        {
            stanica.Id = naplatneStanice.Count > 0 ? naplatneStanice.Last().Id + 1 : 0;
            naplatneStanice.Add(stanica);
        }

        public NaplatnaStanica GetById(int id)
        {
            return naplatneStanice.First(n => n.Id == id);
        }

        public List<NaplatnaStanica> GetAll()
        {
            return naplatneStanice.Where(n => !n.Obrisana).ToList();
        }

        public void Remove(NaplatnaStanica stanica)
        {
            stanica.Obrisana = true;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(naplatneStanice, Formatting.Indented, podesavanja));
        }


    }
}
