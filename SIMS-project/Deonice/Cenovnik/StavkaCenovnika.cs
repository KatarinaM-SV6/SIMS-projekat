using SIMS_project.Transakcije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Deonice.Cenovnik
{
    class StavkaCenovnika
    {
        float cenaRSD;
        float cenaEUR;
        TipVozila tipVozila;
        Deonica deonica;

        public StavkaCenovnika(float cenaRSD, float cenaEUR, TipVozila tipVozila, Deonica deonica)
        {
            this.CenaRSD = cenaRSD;
            this.CenaEUR = cenaEUR;
            this.TipVozila = tipVozila;
            this.Deonica = deonica;
        }

        public float CenaRSD { get => cenaRSD; set => cenaRSD = value; }
        public float CenaEUR { get => cenaEUR; set => cenaEUR = value; }
        public TipVozila TipVozila { get => tipVozila; set => tipVozila = value; }
        public Deonica Deonica { get => deonica; set => deonica = value; }
    }
}
