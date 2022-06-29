using SIMS_project.Korisnici;
using SIMS_project.NaplatneStanice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_project.view.referentView
{
    public partial class GlavnaForma : Form
    {
        private KorisnickiNalog ulogovaniReferent;
        private NaplatnoMesto izabranoMesto;
        public GlavnaForma(KorisnickiNalog referent)
        {
            ulogovaniReferent = referent;
            InitializeComponent();
            FillCBMesto();
        }

        private void FillCBMesto()
        {
            NaplatnaStanica radnoMesto = ulogovaniReferent.Korisnik.RadnoMesto;
            List<KeyValuePair<string, NaplatnoMesto>> data = new List<KeyValuePair<string, NaplatnoMesto>>();
            foreach (NaplatnoMesto naplatnoMesto in radnoMesto.NaplatnaMesta)
            {
                data.Add(new KeyValuePair<string, NaplatnoMesto>("Redni broj mesta: " + naplatnoMesto.RedniBroj, naplatnoMesto));
            }
            cbMesto.DataSource = new BindingSource(data, null);
            cbMesto.DisplayMember = "Key";
            cbMesto.ValueMember = "Value";
        }

        private void CbMesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KeyValuePair<string, NaplatnoMesto> selectedPair = (KeyValuePair<string, NaplatnoMesto>)cbMesto.SelectedItem;
            izabranoMesto = selectedPair.Value;
        }

        private void NaplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (izabranoMesto != null)
            {
                NaplataForma naplataForma = new NaplataForma(ulogovaniReferent, izabranoMesto);
                naplataForma.Show();
            }
            else MessageBox.Show("Izaberite naplatno mesto za pocetak rada.");
        }

        private void DojaviKvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (izabranoMesto != null)
            {
                DojavaKvaraForma dojavaKvaraForma = new DojavaKvaraForma(ulogovaniReferent, izabranoMesto);
                dojavaKvaraForma.Show();
            }
            else MessageBox.Show("Izaberite naplatno mesto za pocetak rada.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
