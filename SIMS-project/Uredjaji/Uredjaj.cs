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

    public class Uredjaj
    {
        int _idUredjaja = -1;
        VrstaUredjaja _vrstaUredjaja;
        bool _uFunkciji;

        public Uredjaj() { }

        public Uredjaj(String vrstaUredjaja)
        {
            _vrstaUredjaja = (VrstaUredjaja)Enum.Parse(typeof(VrstaUredjaja), vrstaUredjaja);
            _uFunkciji = true;
        }

        [JsonConverter(typeof(StringEnumConverter))]

        public VrstaUredjaja VrstaUredjaja { get { return _vrstaUredjaja;} set { _vrstaUredjaja = value; } }
        public bool UFunkciji { get { return _uFunkciji;} set { _uFunkciji = value;} }

        public int IdUredjaja { get => _idUredjaja; set => _idUredjaja = value; }

        public override string ToString()
        {
            return "\nVrsta uredjaja: " + VrstaUredjaja.ToString() + ", Radi: " + UFunkciji.ToString();
        }
    }

    
}
