using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Komponente;
using System.Threading;

namespace SHES
{
    public class Metode : IMetode
    {
        public void dodavanjeBaterije()
        {

            SHESContext sc = new SHESContext();


            Console.WriteLine("Unesite ime baterije:");
            string baterijaIme = Console.ReadLine();

            var pomocni = sc.Baterije.Find(baterijaIme);

            if (pomocni != null)
            {
                Console.WriteLine("Baterija sa tim imenom vec postoji!");
            }
            else
            {
                Console.WriteLine("Unesite maksimalnu snagu baterije:");
                int maxSnaga = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Unesite kapacitet baterije:");
                int kapacitet = Int32.Parse(Console.ReadLine());

                Baterija bat = new Baterija(baterijaIme, maxSnaga, kapacitet);

                using (var db = new SHESContext())
                {
                     db.Baterije.Add(bat);
                     db.SaveChanges();
                     Console.WriteLine("Baterija " + bat.Ime + " dodata u sistem");
                }
            }

        }

        public void dodavanjePotrosaca()
        {

            SHESContext sc = new SHESContext();

            Console.WriteLine("Unesite ime potrosaca: ");
            string ip = Console.ReadLine();

            var pomocni = sc.Potrosaci.Find(ip);

            if (pomocni != null)
            {
                Console.WriteLine("Potrosac sa tim imenom vec postoji!");
            }
            else
            {
                Console.WriteLine("Unesite potrosnju: ");
                int pp = Int32.Parse(Console.ReadLine());

                Potrosac potrosac = new Potrosac(ip, pp);

                using (var db = new SHESContext())
                {
                    db.Potrosaci.Add(potrosac);
                    db.SaveChanges();
                    Console.WriteLine("Potrosac " + potrosac.Ime + " dodat u sistem");

                }
            }
        }
    
        public void dodavanjeSolarnogPanela()
        {
          
            SHESContext sc = new SHESContext();
            
            Console.WriteLine("Unesite ime panela: ");
            string imePanela = Console.ReadLine();

            var pomocni = sc.Paneli.Find(imePanela);

            if (pomocni != null)
            {
                Console.WriteLine("Panel sa zadatim imenom vec postoji u bazi!");
               
            }
            else
            {
                Console.WriteLine("unesite maksimalnu snagu panela");
                int s = Int32.Parse(Console.ReadLine());

                SolarniPanel sp = new SolarniPanel(imePanela, s);

                using (var db = new SHESContext())
                {
                    sp.TrenutnaSnaga = sp.MaxSnaga * 1;
                    db.Paneli.Add(sp);
                    db.SaveChanges();
                    Console.WriteLine("Panel uspesno dodat");

                }
            }

        }

        public void merenjeSnageSolarnihPanela()
        {
            SHESContext sc = new SHESContext();
            List<SolarniPanel> p = new List<SolarniPanel>();
            Podaci podaci = new Podaci();

            p = sc.Paneli.ToList<SolarniPanel>();
            int ukupnaSnaga = 0;

            for(int i = 0; i < p.Count; i++)
            {
                ukupnaSnaga += p[i].TrenutnaSnaga;
            }
            Console.WriteLine("Ukupna snaga svih panela: " + ukupnaSnaga);

            podaci.SnagaPanela = ukupnaSnaga;
            podaci.StanjeBaterije
        }

        public void snagaSunca()
        {
           // Thread.Sleep(1000);

            SHESContext sc = new SHESContext();
            List<SolarniPanel> paneli = new List<SolarniPanel>();

            paneli = sc.Paneli.ToList<SolarniPanel>();

            Console.WriteLine("LISTA PANELA");
            for(int j = 0; j < paneli.Count; j++)
            {
                Console.WriteLine("Panel: " + paneli[j].Ime);
            }
            
            
            Console.WriteLine("Unesite ime panela kome zelite da promenite snagu sunca:");

            string i = Console.ReadLine();

            int s = 0;

            for(int j = 0; j < paneli.Count; j++)
            {
                if (!paneli[j].Ime.Equals(i))
                    continue;
                else
                {
                    Console.WriteLine("Panel pronadjen.");
                    Console.WriteLine("Unesite snagu sunca za odabrani panel:");
                    s = Int32.Parse(Console.ReadLine());

                    paneli[j].TrenutnaSnaga = paneli[j].MaxSnaga * s / 100;

                    Console.WriteLine("Panel: " + paneli[j].Ime + " Trenutna snaga:" + paneli[j].TrenutnaSnaga);

                }
                
            }
            
        }

    }
}
