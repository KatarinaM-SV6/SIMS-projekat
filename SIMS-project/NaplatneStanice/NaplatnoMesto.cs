using SIMS_project.Uredjaji;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SIMS_project.NaplatneStanice
{
    public class NaplatnoMesto
    {
        bool _imaElektronskoNaplacivanje;
        bool _uFunkciji;
        int _redniBroj = -1;
        List<Uredjaj> _uredjaji;
        public NaplatnoMesto()
        {
        }

        public NaplatnoMesto(bool imaElektronskoNaplacivanje, bool uFunkciji, List<Uredjaj> uredjaji)
        {
            this._imaElektronskoNaplacivanje = imaElektronskoNaplacivanje;
            this._uFunkciji = uFunkciji;
            this._uredjaji = uredjaji;
        }

        public bool ImaElektronskoNaplacivanje { get { return _imaElektronskoNaplacivanje; } set { _imaElektronskoNaplacivanje = value; } }
        public int RedniBroj { get { return _redniBroj; } set { _redniBroj = value; } }
        public List<Uredjaj> Uredjaji { get { return _uredjaji; } set { _uredjaji = value; } }
        public bool UFunkciji { get { return _uFunkciji; } set { _uFunkciji = value; } }

        public override string ToString()
        {
            return "Redni broj: " + RedniBroj + ", U funkciji: " + UFunkciji + ", Elektronsko naplacivanje" + ImaElektronskoNaplacivanje;
        }

    }
}
