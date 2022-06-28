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
using SIMS_project.Transakcije;

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
			if (!TacanUnos()) return;
			if (_tipIzvestaja == "i")
			{
				//naslov.Text = "Izvestaj za promet";
			}
			else if (_tipIzvestaja == "t")
			{
				PrikaziIzvestajPoTipuVozila();
			}
		}

		private void PrikaziIzvestajPoTipuVozila()
		{
			DateTime pocetak = DateTime.ParseExact(pocetakTextBox.Text, "dd.MM.yyyy.", null);
			DateTime kraj = DateTime.ParseExact(krajTextBox.Text, "dd.MM.yyyy.", null);
			List<Transakcija> transakcije = Program.transakcijaRepo.GetForStation(_naplatnaStanica.Id);

			Dictionary<string, int> brojPoTipu = NadiBrojPoTipu(pocetak, kraj, transakcije);
			Dictionary<string, float> cenaPoTipu = NadiCenuPoTipu(pocetak, kraj, transakcije);

			string izvestaj = GenerisiTeks(brojPoTipu, cenaPoTipu);
			izvestajTextBox.Text = izvestaj;
			
		}

		private string GenerisiTeks(Dictionary<string, int> brojPoTipu, Dictionary<string, float> cenaPoTipu)
		{
			string izvestaj = "";
			foreach (string tip in brojPoTipu.Keys)
			{
				izvestaj += tip + "\r\n";
				izvestaj += "\tBroj vozila: " + brojPoTipu[tip] + "\tIznos: " + cenaPoTipu[tip] + "\r\n";
			}
			return izvestaj;
		}

		private Dictionary<string, float> NadiCenuPoTipu(DateTime pocetak, DateTime kraj, List<Transakcija> transakcije)
		{
			Dictionary<string, float> cenaPoTipu = new Dictionary<string, float>();
			foreach (Transakcija transakcija in transakcije)
			{
				string tip = transakcija.TipVozila.ToString();
				if (pocetak <= transakcija.VremeUlaska && transakcija.VremeIzlaska <= kraj)
				{
					if (!cenaPoTipu.ContainsKey(tip)) cenaPoTipu.Add(tip, 0);
					cenaPoTipu[tip] += transakcija.Iznos;
				}
			}
			return cenaPoTipu;
		}

		private Dictionary<string, int> NadiBrojPoTipu(DateTime pocetak, DateTime kraj, List<Transakcija> transakcije)
		{
			Dictionary<string, int> cenaPoTipu = new Dictionary<string, int>();
			foreach (Transakcija transakcija in transakcije)
			{
				string tip = transakcija.TipVozila.ToString();
				if (pocetak <= transakcija.VremeUlaska && transakcija.VremeIzlaska <= kraj)
				{
					if (!cenaPoTipu.ContainsKey(tip)) cenaPoTipu.Add(tip, 0);
					cenaPoTipu[tip] += 1;
				}
			}
			return cenaPoTipu;
		}

		private bool TacanUnos()
		{
			try
			{
				DateTime beginningCheck = DateTime.ParseExact(pocetakTextBox.Text, "dd.MM.yyyy.", null);
				beginningCheck = DateTime.ParseExact(krajTextBox.Text, "dd.MM.yyyy.", null);
				return true;
			}
			catch
			{
				MessageBox.Show("Proverite ispravnost datuma.", "Error");
				return false;
			}
		}
	}
}
