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
using SIMS_project.Uredjaji.DojaveOKvaru;

namespace SIMS_project.view.vodjaView
{
	public partial class PrijaveKvarovaForm : Form
	{
		readonly private NaplatnaStanica _naplatnaStanica;
		public PrijaveKvarovaForm()
		{
			InitializeComponent();
		}
		public PrijaveKvarovaForm(NaplatnaStanica naplatnaStanica)
		{
			_naplatnaStanica = naplatnaStanica;
			InitializeComponent();
			FillTable();
		}

		private void FillTable()
		{
			List<DojavaOKvaru> dojavaOKvarovima = Program.dojaveRepo.GetAll();
			foreach (DojavaOKvaru dojava in dojavaOKvarovima) {
				if (dojava.NaplatnaStanica.Id == _naplatnaStanica.Id) {
					dataGridView1.Rows.Add(dojava.Datum, dojava.Uredjaj.VrstaUredjaja.ToString(), dojava.OpisKvara, dojava.Obradjena);
				}
			}

		}

		private void OtkaziDugme(object sender, EventArgs e)
		{
			Close();
		}
	}
}
