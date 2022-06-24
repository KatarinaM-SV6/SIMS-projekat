using SIMS_project.Uredjaji;
using System.Collections.Generic;

namespace SIMS_project.NaplatneStanice
{
    public class NaplatnoMesto
    {
        int _id;
        bool _imaElektronskoNaplacivanje;
        bool _uFunkciji;
        int _redniBroj;
        List<Uredjaj> _uredjaji;
        public NaplatnoMesto()
        {
        }

        public NaplatnoMesto(int id, bool imaElektronskoNaplacivanje, bool uFunkciji, int redniBroj, List<Uredjaj> uredjaji)
        {
            this._id = id;
            this._imaElektronskoNaplacivanje = imaElektronskoNaplacivanje;
            this._uFunkciji = uFunkciji;
            this._redniBroj = redniBroj;
            this._uredjaji = uredjaji;
        }

        public int Id { get { return _id; } set { _id = value; } } 
        public bool ImaElektronskoNaplacivanje { get { return _imaElektronskoNaplacivanje; } set { _imaElektronskoNaplacivanje = value; } }
        public int RedniBroj { get { return _redniBroj; } set { _redniBroj = value; } }
        public List<Uredjaj> Uredjaji { get { return _uredjaji; } set { _uredjaji = value; } }
        public bool UFunkciji { get { return _uFunkciji; } set { _uFunkciji = value; } }

        public override string ToString()
        {
            string str = "\nRedni broj: " + RedniBroj + "\nJe u funkciji: " + UFunkciji + "\nIma elektronsko naplacivanje" + ImaElektronskoNaplacivanje;
            foreach (Uredjaj uredjaj in Uredjaji)
            {
                str += "\t" + uredjaj.ToString();
            }
            return str;
        }
    }
}
