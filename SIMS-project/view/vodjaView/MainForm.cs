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
using SIMS_project.Uredjaji;

namespace SIMS_project.view.vodjaView
{
	public partial class MainForm : Form
	{
		private NaplatnaStanica _naplatnaStanica = Program.staniceRepo.GetByMesto("Mesto1");
		public MainForm()
		{
			InitializeComponent();
			FillTable();
		}

		private void FillTable()
		{
			foreach (NaplatnoMesto naplatnoMesto in _naplatnaStanica.NaplatnaMesta) {
				dataGridView1.Rows.Add(naplatnoMesto.RedniBroj, naplatnoMesto.ImaElektronskoNaplacivanje, naplatnoMesto.UFunkciji, naplatnoMesto.Uredjaji.Count);
			}
		}

		private void PromeniUfunciji(object sender, EventArgs e)
		{
			if (!OneRowSelected()) return;
			NaplatnoMesto selektovanoMesto = DobaviSelektovanoRadnoMesto(); 
			bool uFunkcijiNovo = true;
			if (selektovanoMesto.UFunkciji) uFunkcijiNovo = false;
			SacuvajPromene(selektovanoMesto, uFunkcijiNovo);

		}

		private void SacuvajPromene(NaplatnoMesto selektovanoMesto, bool uFunkcijiNovo)
		{
			DialogResult dialogResult = MessageBox.Show("Da li zelite da radnu stanicu " + selektovanoMesto.RedniBroj + " prebacite funkciju u stanje " + uFunkcijiNovo + "?", "Check", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				selektovanoMesto.UFunkciji = uFunkcijiNovo;
			}
		}

		private NaplatnoMesto DobaviSelektovanoRadnoMesto()
		{
			string redniBrojMesta = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			foreach (NaplatnoMesto naplatnoMesto in _naplatnaStanica.NaplatnaMesta)
			{
				if (naplatnoMesto.RedniBroj == int.Parse(redniBrojMesta)) return naplatnoMesto;
			}
			return null;
		}

		private void UvidUUredjaje(object sender, EventArgs e)
		{
			if (OneRowSelected())
			{
				UredajiForm uredajiForm = new UredajiForm(DobaviUredjaje());
				uredajiForm.Show();
			}
		}

		private void UvidUprijaveKvarova(object sender, EventArgs e)
		{
			PrijaveKvarovaForm prijaveKvarova = new PrijaveKvarovaForm(_naplatnaStanica);
			prijaveKvarova.Show();
		}

		private void IzvestajPromet(object sender, EventArgs e)
		{

		}

		private void IzvestajTipVozila(object sender, EventArgs e)
		{

		}

		private List<Uredjaj> DobaviUredjaje() {
			string redniBrojMesta = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			foreach (NaplatnoMesto naplatnoMesto in _naplatnaStanica.NaplatnaMesta) {
				if (naplatnoMesto.RedniBroj == int.Parse(redniBrojMesta)) return naplatnoMesto.Uredjaji; 
			}
			return null;
		}

		private bool OneRowSelected()
		{
			int selectedRowCount =
			dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
			if (selectedRowCount == 1) return true;
			else
			{
				MessageBox.Show("Oznacite samo jedan red.", "Error");
				return false;
			}
		}
	}
}
