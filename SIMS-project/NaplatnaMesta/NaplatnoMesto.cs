using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.NaplatnaMesta
{
    internal class NaplatnoMesto
    {
        int id { get; set; }
        bool imaElektronskoNaplacivanje { get; set; }
        bool uFunkciji { get; set; }
        int redniBroj { get; set; }
        public NaplatnoMesto()
        {
        }

        public NaplatnoMesto(int id, bool imaElektronskoNaplacivanje, bool uFunkciji, int redniBroj)
        {
            this.id = id;
            this.imaElektronskoNaplacivanje = imaElektronskoNaplacivanje;
            this.uFunkciji = uFunkciji;
            this.redniBroj = redniBroj;
        }


    }
}
