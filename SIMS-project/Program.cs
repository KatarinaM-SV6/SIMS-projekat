using Newtonsoft.Json;
using SIMS_project.Korisnici;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS_project.NaplatneStanice;
using SIMS_project.Uredjaji;
using SIMS_project.Uredjaji.DojaveOKvaru;
using SIMS_project.Pogled.Referent;
using SIMS_project.Deonice;

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;
        private static readonly JsonSerializerSettings jsonPodesavanja = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.None };
        public static KorisnikRepository korisniciRepo = new KorisnikRepository(podaciDir + "korisnici.json", jsonPodesavanja);
        public static KorisnickiNalogRepository naloziRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPodesavanja);
        public static NaplatnaStanicaRepository staniceRepo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
        public static DojavaOKvaruRepository dojaveRepo = new DojavaOKvaruRepository(podaciDir + "DojaveOKvaru.json", jsonPodesavanja);
        public static DeonicaRepository deoniceRepo = new DeonicaRepository(podaciDir + "Deonice.json", jsonPodesavanja);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*var korisniciRepo = new KorisnikRepository(podaciDir + "korisnici.json", jsonPosesavanja);

            korisniciRepo.Add(new Korisnik("Milan", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Jelena", "Ristic"));
            korisniciRepo.Add(new Korisnik("Nikola", "Milovanovic"));
            korisniciRepo.Add(new Korisnik("Milan", "Krstic"));

            var kornalogRepo = new KorisnickiNalogRepository(podaciDir + "korisnicki_nalozi.json", jsonPosesavanja);

            foreach (var k in korisniciRepo.GetAll())
            {
                kornalogRepo.Add(new KorisnickiNalog(k.Ime+k.Prezime, "123", TipKorisnika.REFERENT, k));
            }
            korisniciRepo.Save();
            kornalogRepo.Save();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void test()
        {
            NaplatnaStanicaRepository repo = new NaplatnaStanicaRepository(podaciDir + "NaplatneStanice.json", jsonPodesavanja);
            List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
            for (int i = 1; i < 5; i++)
            {
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(new Mesto("Mesto" + i), new List<NaplatnoMesto>(), "A" + i);
                for (int j = 1; j < 10; j++)
                {
                    NaplatnoMesto naplatnoMesto = new NaplatnoMesto(false, true, new List<Uredjaj> { new Uredjaj("KAMERA"), new Uredjaj("RAMPA") });
                    naplatnaStanica.AddMesto(naplatnoMesto);
                }
                naplatneStanice.Add(naplatnaStanica);
                repo.Add(naplatnaStanica);
            }
            string jsonString = JsonConvert.SerializeObject(naplatneStanice, Formatting.Indented);

            Console.WriteLine(jsonString);
            repo.Save();
        }

    }
}
