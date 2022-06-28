using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.NaplatneStanice;

namespace SIMS_project.view.vodjaView
{
	public partial class IzvestajForm : Form
	{
		readonly private string _tipIzvestaja;
		readonly private NaplatnaStanica _naplatnaStanica;

		public IzvestajForm()
		{
			InitializeComponent();
		}

		public IzvestajForm(string v, NaplatnaStanica naplatnaStanica)
		{
			_tipIzvestaja = v;
			_naplatnaStanica = naplatnaStanica;
			InitializeComponent();
			NamestiNaslov();
		}

		private void NamestiNaslov()
		{
			if (_tipIzvestaja == "i") {
				naslov.Text = "Izvestaj za promet";
			}
			else if (_tipIzvestaja == "t") {
				naslov.Text = "Izvestaj za tip vozila";
			}
		}

		private void PrikaziIzvestaj(object sender, EventArgs e)
		{

		}
	}
}
