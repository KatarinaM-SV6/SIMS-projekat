using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.NaplatneStanice
{
    public class NaplatnaStanica
    {
        int _id = -1;
        Mesto _mesto;
        List<NaplatnoMesto> _naplatnaMesta;
        String _nazivAutoputa;
        bool _obrisana;

        public NaplatnaStanica() { }
        
        public NaplatnaStanica(Mesto mesto, List<NaplatnoMesto> naplatnaMesta, String nazivAutoputa)
        {
            _mesto = mesto;
            _naplatnaMesta = naplatnaMesta;
            _nazivAutoputa = nazivAutoputa;
        }
        
        public int Id { get { return _id; } set { _id = value; } }
        public Mesto Mesto { get { return _mesto; } set { _mesto = value; } }
        public List<NaplatnoMesto> NaplatnaMesta { get { return _naplatnaMesta;} set { _naplatnaMesta = value;} }
        public String NazivAutoputa { get { return _nazivAutoputa; } set { _nazivAutoputa = value; } }
        public bool Obrisana { get { return _obrisana;} set { _obrisana = value;} }

        public override string ToString()
        {
            return "\nID: " + _id + ", Mesto: " + _mesto.Naziv + ", Naziv autoputa: " + _nazivAutoputa;
        }
    }
}
