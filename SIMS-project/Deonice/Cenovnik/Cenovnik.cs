﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice.Cenovnik
{
    class Cenovnik
    {
        DateTime pocetakVazenja;
        DateTime krajVazenja;
        List<StavkaCenovnika> stavke;

        public Cenovnik(DateTime pocetakVazenja, DateTime krajVazenja, List<StavkaCenovnika> stavke)
        {
            this.PocetakVazenja = pocetakVazenja;
            this.KrajVazenja = krajVazenja;
            this.Stavke = stavke;
        }

        public DateTime PocetakVazenja { get => pocetakVazenja; set => pocetakVazenja = value; }
        public DateTime KrajVazenja { get => krajVazenja; set => krajVazenja = value; }
        internal List<StavkaCenovnika> Stavke { get => stavke; set => stavke = value; }
    }
}
