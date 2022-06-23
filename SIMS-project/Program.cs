using Newtonsoft.Json;
using SIMS_project.Korisnici;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_project
{
    static class Program
    {
        private static readonly string podaciDir = Path.Combine("..", "..", "Podaci") + Path.DirectorySeparatorChar;
        private static readonly JsonSerializerSettings jsonPosesavanja = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.None };
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
    }
}
