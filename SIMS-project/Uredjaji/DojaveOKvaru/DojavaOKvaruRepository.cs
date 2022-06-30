using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Uredjaji.DojaveOKvaru
{
    class DojavaOKvaruRepository
    {
        private List<DojavaOKvaru> dojave = new List<DojavaOKvaru>();
        private readonly string fNaziv;
        private readonly JsonSerializerSettings podesavanja;

        public DojavaOKvaruRepository(string fNaziv, JsonSerializerSettings podesavanja)
        {
            this.fNaziv = fNaziv;
            this.podesavanja = podesavanja;
            DojavaOKvaruJSONReferenceConverter.Repo = this;
            dojave = JsonConvert.DeserializeObject<List<DojavaOKvaru>>(File.ReadAllText(fNaziv), podesavanja);
        }

        public void Add(DojavaOKvaru dojava)
        {
            dojava.Id = dojave.Count > 0 ? dojave.Last().Id + 1 : 0;
            dojave.Add(dojava);
        }

        public List<DojavaOKvaru> GetAll()
        {
            return dojave;
        }

        public void Save()
        {
            File.WriteAllText(fNaziv, JsonConvert.SerializeObject(dojave, Formatting.Indented, podesavanja));
        }

    }
}
