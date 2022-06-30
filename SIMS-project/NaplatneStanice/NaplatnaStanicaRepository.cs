using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using SIMS_project.Uredjaji;

namespace SIMS_project.NaplatneStanice
{
    public class NaplatnaStanicaRepository
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

        public void Update(NaplatnaStanica stanica)
        {
            var result = from s in naplatneStanice where s.Id == stanica.Id select s;

            result.First().NazivAutoputa = stanica.NazivAutoputa;
            result.First().Mesto = stanica.Mesto;
            result.First().NaplatnaMesta = stanica.NaplatnaMesta;

            Save();
        }
        public NaplatnaStanica GetByMesto(String mesto)
        {
            return naplatneStanice.First(n => n.Mesto.Naziv == mesto);
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

        public NaplatnaStanica PronadjiPoNaplatnomMestu(NaplatnoMesto naplatnoMesto)
        {
            foreach (NaplatnaStanica stanica in naplatneStanice)
            {
                foreach (NaplatnoMesto mesto in stanica.NaplatnaMesta)
                {
                    Uredjaj uredjaj = mesto.Uredjaji[0];
                    if (naplatnoMesto.Uredjaji.Any(u => u.IdUredjaja == uredjaj.IdUredjaja))
                    {
                        return stanica;
                    }
                }
            }
            return null;
        }


    }
}
