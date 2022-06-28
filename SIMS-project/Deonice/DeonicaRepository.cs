using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice
{
    class DeonicaRepository
    {
        private List<Deonica> deonice = new List<Deonica>();
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;

        public DeonicaRepository(string fNaziv, JsonSerializerSettings podesavanja)
        {
            this.fNaziv = fNaziv;
            this.podesavanja = podesavanja;
            DeonicaJSONReferenceConverter.Repo = this;
            deonice = JsonConvert.DeserializeObject<List<Deonica>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(Deonica deonica)
        {
            deonica.Id = deonice.Count > 0 ? deonice.Last().Id + 1 : 0;
            deonice.Add(deonica);
        }

        public List<Deonica> GetAll()
        {
            return deonice;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(deonice, Formatting.Indented, podesavanja));
        }
    }
}
