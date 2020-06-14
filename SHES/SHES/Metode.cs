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
            if (System.Text.RegularExpressions.Regex.IsMatch(baterijaIme, "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos imena!");
            }

            Console.WriteLine("Unesite maksimalnu snagu baterije:");
            string maxSnaga = Console.ReadLine();
            if (!Int32.TryParse(maxSnaga, out int a))
            {
                Console.WriteLine("Neispravan unos maksimalne snage!");

            }


            Console.WriteLine("Unesite kapacitet baterije:");
            string kapacitet = Console.ReadLine();
            if (!Int32.TryParse(kapacitet, out int b))
            {
                Console.WriteLine("Neispravan unos kapaciteta!");

            }

            Baterija bat = new Baterija(baterijaIme, a, b);

            using (var db = new SHESContext())
            {
                foreach (Baterija bb in db.Baterije)
                {
                    if (!bb.Ime.Equals(baterijaIme))
                    {
                        db.Baterije.Add(bb);
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
            SHESContext db = new SHESContext();

            Console.WriteLine("Unesite ime potrosaca: ");
            string ip = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(ip, "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos imena!");
            }

            Console.WriteLine("Unesite potrosnju: ");
            string pp = Console.ReadLine();
            if (!Int32.TryParse(pp, out int a))
            {
                Console.WriteLine("Neispravan unos maksimalne snage!");

            }

            Potrosac potrosac = new Potrosac(ip, a);
            List<Potrosac> potrosaci = new List<Potrosac>();
            potrosaci = db.Potrosaci.ToList<Potrosac>();

            using (db)
            {
                for (int i = 0; i < potrosaci.Count; i++)
                {
                    if (!potrosaci[i].Ime.Contains(ip))
                    {
                        db.Potrosaci.Add(potrosac);
                        db.SaveChanges();
                        Console.WriteLine("Potrosac  " + potrosac.Ime + "  dodat u sistem");
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
            Console.WriteLine("Unesite ime panela: ");
            string i = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(i, "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos imena!");
            }

            Console.WriteLine("Unesite maksimalnu snagu panela: ");
            string snaga = Console.ReadLine();
            if(!Int32.TryParse(snaga, out int a))
            {
                Console.WriteLine("Neispravan unos maksimalne snage!");

            }
           
            SolarniPanel sp = new SolarniPanel(i, a);

            
            using (var db = new SHESContext())
            {
                 db.Paneli.Add(sp);
                 db.SaveChanges();
                 Console.WriteLine("Solarni panel" + sp.Ime + "uspesno dodat!");                               
            }

        }

        public void snagaSunca()
        {
            SHESContext sc = new SHESContext();

            foreach (SolarniPanel panel in sc.Paneli)
            {
                Console.WriteLine("Solarni panel:" + panel.Ime);

            }
            Console.WriteLine("Unesite ime panela kome zelite da promenite snagu sunca:");

            string i = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(i, "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos imena!");
            }

            Console.WriteLine("Unesite snagu sunca za izabrani panel:");
            int s = Int32.Parse(Console.ReadLine());
            if (!System.Text.RegularExpressions.Regex.IsMatch(s.ToString(), "^[0-9]"))
            {
                Console.WriteLine("Neispravan unos maksimalne snage!");
            }

            foreach (SolarniPanel panel in sc.Paneli)
            {
                if (panel.Ime.Equals(i))
                {
                    panel.TrenutnaSnaga = panel.MaxSnaga * s / 100;
                    Console.WriteLine("Snaga sunca za panel " + panel.Ime + "je izmenjena." + Environment.NewLine + "Trenutna snaga panela:" + panel.TrenutnaSnaga);
                }
                else
                    Console.WriteLine("Panel sa zadatim imenom ne postoji!");
            }
        }

        public void trenutnaSnagaPanela(string ime, int snaga)
        {
            
        }
    }
}
