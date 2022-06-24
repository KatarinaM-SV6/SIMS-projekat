using SIMS_project.Transakcije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.Tagovi
{
    class Tag
    {
        int id;
        TipVozila tipVozila;
        string ime;
        string prezime;
        float stanjeRacuna;

        public Tag()
        {
        }

        public Tag(int id, TipVozila tipVozila, string ime, string prezime, float stanjeRacuna)
        {
            this.Id = id;
            this.TipVozila = tipVozila;
            this.Ime = ime;
            this.Prezime = prezime;
            this.StanjeRacuna = stanjeRacuna;
        }

        public int Id { get => id; set => id = value; }
        public TipVozila TipVozila { get => tipVozila; set => tipVozila = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public float StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }
    }
}
