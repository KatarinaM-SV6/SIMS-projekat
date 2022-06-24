using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Uredjaji
{
    public enum VrstaUredjaja
    {
        KAMERA,
        RAMPA,
        SEMAFOR,
        CITAC_TAGA,
        CITAC_TABLICA
    }

    internal class Uredjaj
    {
        VrstaUredjaja _vrstaUredjaja;

        public Uredjaj() { }

        public Uredjaj(String vrstaUredjaja)
        {
            _vrstaUredjaja = (VrstaUredjaja)Enum.Parse(typeof(VrstaUredjaja), vrstaUredjaja);
        }

        [JsonConverter(typeof(StringEnumConverter))]

        public VrstaUredjaja VrstaUredjaja { get { return _vrstaUredjaja;} set { _vrstaUredjaja = value; } }
    }

    
}
