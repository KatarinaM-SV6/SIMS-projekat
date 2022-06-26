using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.Uredjaji;

namespace SIMS_project.view.vodjaView
{
	public partial class UredajiForm : Form
	{
		private List<Uredjaj> uredjaji;

		public UredajiForm()
		{
			InitializeComponent();
		}

		public UredajiForm(List<Uredjaj> uredjaji)
		{
			InitializeComponent();
			this.uredjaji = uredjaji;
			FillTable();
		}

		private void FillTable()
		{
			foreach (Uredjaj uredjaj in uredjaji)
			{
				dataGridView1.Rows.Add(uredjaj.VrstaUredjaja.ToString(), uredjaj.UFunkciji);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
