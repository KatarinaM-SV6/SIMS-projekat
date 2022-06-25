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
	public partial class MainForm : Form
	{
		private NaplatnaStanica _naplatnaStanica = Program.staniceRepo.GetByMesto("555");
		public MainForm()
		{
			InitializeComponent();
			FillTable();
		}

		private void FillTable()
		{
			foreach (NaplatnoMesto naplatnoMesto in _naplatnaStanica.NaplatnaMesta) {
				dataGridView1.Rows.Add(naplatnoMesto.RedniBroj, naplatnoMesto.ImaElektronskoNaplacivanje, naplatnoMesto.UFunkciji, naplatnoMesto.Uredjaji);
			}
		}

		private void PromeniUfunciji(object sender, EventArgs e)
		{

		}

		private void UvidUUredjaje(object sender, EventArgs e)
		{

		}

		private void UvidUprijaveKvarova(object sender, EventArgs e)
		{

		}

		private void IzvestajPromet(object sender, EventArgs e)
		{

		}

		private void IzvestajTipVozila(object sender, EventArgs e)
		{

		}
	}
}
