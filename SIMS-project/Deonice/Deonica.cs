using Newtonsoft.Json;
using SIMS_project.NaplatneStanice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice
{
    class Deonica
    {
        int id;
        int kilometraza;
        NaplatnaStanica mestoUlaska;
        NaplatnaStanica mestoIzlaska;

        public Deonica() { }
        public Deonica(int id, int kilometraza, NaplatnaStanica mestoUlaska, NaplatnaStanica mestoIzlaska)
        {
            this.Id = id;
            this.Kilometraza = kilometraza;
            this.MestoUlaska = mestoUlaska;
            this.MestoIzlaska = mestoIzlaska;
        }

        public Deonica(int kilometraza, NaplatnaStanica mestoUlaska, NaplatnaStanica mestoIzlaska)
        {
            this.Kilometraza = kilometraza;
            this.MestoUlaska = mestoUlaska;
            this.MestoIzlaska = mestoIzlaska;
        }

        public int Id { get => id; set => id = value; }
        public int Kilometraza { get => kilometraza; set => kilometraza = value; }

        [JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
        public NaplatnaStanica MestoUlaska { get => mestoUlaska; set => mestoUlaska = value; }

        [JsonConverter(typeof(NaplatnaStanicaJSONReferenceConverter))]
        public NaplatnaStanica MestoIzlaska { get => mestoIzlaska; set => mestoIzlaska = value; }
    }
}
