using SIMS_project.Korisnici;
using SIMS_project.NaplatneStanice;
using SIMS_project.Uredjaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_project.Pogled.Referent
{
    public partial class DojavaKvaraForma : Form
    {
        private KorisnickiNalog ulogovaniReferent;
        private NaplatnoMesto naplatnoMesto;
        private Uredjaj izabranUredjaj;

        public DojavaKvaraForma(KorisnickiNalog ulogovaniReferent, NaplatnoMesto naplatnoMesto)
        {
            this.ulogovaniReferent = ulogovaniReferent;
            this.naplatnoMesto = naplatnoMesto;
            InitializeComponent();
            FillCBUredjaji();
        }

        private void FillCBUredjaji()
        {
            List<KeyValuePair<string, Uredjaj>> data = new List<KeyValuePair<string, Uredjaj>>();
            foreach (Uredjaj uredjaj in naplatnoMesto.Uredjaji)
            {
                data.Add(new KeyValuePair<string, Uredjaj>(uredjaj.VrstaUredjaja.ToString() + " sa Id " + uredjaj.IdUredjaja, uredjaj));
            }
            cbUredjaji.DataSource = new BindingSource(data, null);
            cbUredjaji.DisplayMember = "Key";
            cbUredjaji.ValueMember = "Value";
        }

        private void CbUredjaji_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KeyValuePair<string, Uredjaj> selectedPair = (KeyValuePair<string, Uredjaj>)cbUredjaji.SelectedItem;
            izabranUredjaj = selectedPair.Value;
        }

        private void BtnDojavi_Click(object sender, EventArgs e)
        {
            if (izabranUredjaj != null)
            {
                Program.dojaveRepo.Add(new Uredjaji.DojaveOKvaru.DojavaOKvaru(DateTime.Now, izabranUredjaj.IdUredjaja, tbOpis.Text, chbObustavi.Checked, ulogovaniReferent.Korisnik.RadnoMesto));
                MessageBox.Show("Uspesno poslata dojava.");
            }
            else MessageBox.Show("Izaberite uredjaj.");
        }
    }
}
