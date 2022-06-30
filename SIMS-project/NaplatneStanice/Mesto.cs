using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_project.NaplatneStanice
{
    public class Mesto
    {
        String _naziv;

        public Mesto(String naziv)
        {
            _naziv = naziv;
        }

        public String Naziv { get { return _naziv; } set { _naziv = value; } }

        public override string ToString()
        {
            return _naziv;
        }
    }
}
