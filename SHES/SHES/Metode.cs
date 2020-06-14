using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Komponente;

namespace SHES
{
    public class Metode : IMetode
    {
        public void dodavanjeBaterije()
        {
            Console.WriteLine("Unesite ime baterije:");
            string baterijaIme = Console.ReadLine();

            Console.WriteLine("Unesite maksimalnu snagu baterije:");
            int maxSnaga = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Unesite kapacitet baterije:");
            int kapacitet = Int32.Parse(Console.ReadLine());

            Baterija bat = new Baterija(baterijaIme, maxSnaga, kapacitet);

            using (var db = new SHESContext())
            {
                foreach (Baterija b in db.Baterije)
                {
                    if (!b.Ime.Equals(baterijaIme))
                    {
                        db.Baterije.Add(b);
                        db.SaveChanges();
                        Console.WriteLine("Baterija " + bat.Ime + " dodata u sistem");
                    }
                    else
                    {
                        Console.WriteLine("Baterija sa tim imenom vec postoji!");
                    }
                }
            }
        }

        public void dodavanjePotrosaca()
        {
            Console.WriteLine("Unesite ime potrosaca: ");
            string ip = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(ip, "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos imena!");
            }

            Console.WriteLine("Unesite potrosnju: ");
            int pp = Int32.Parse(Console.ReadLine());
            if (!System.Text.RegularExpressions.Regex.IsMatch(pp.ToString(), "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos potrosnje!");
            }

            Potrosac potrosac = new Potrosac(ip, pp);

            using (var db = new SHESContext())
            {
                foreach (Potrosac p in db.Potrosaci)
                {
                    if (!p.Ime.Equals(potrosac.Ime))
                    {

                        db.Potrosaci.Add(p);
                        db.SaveChanges();
                        Console.WriteLine("Potrosac " + p.Ime + " dodat u sistem");
                    }
                    else
                    {
                        Console.WriteLine("Potrosac sa tim imenom vec postoji!");
                    }
                }
            }
        }

        public void dodavanjeSolarnogPanela()
        {
          
            SHESContext sc = new SHESContext();
            List<SolarniPanel> paneli = new List<SolarniPanel>();

            paneli = sc.Paneli.ToList<SolarniPanel>();

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
                    db.Paneli.Add(sp);
                    db.SaveChanges();
                    Console.WriteLine("Panel uspesno dodat");

                }
            }

        }
            
        public void snagaSunca()
        {
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
