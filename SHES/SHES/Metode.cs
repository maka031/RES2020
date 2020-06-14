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
            Console.WriteLine("Unesite ime panela: ");
            string i = Console.ReadLine();

            Console.WriteLine("Unesite maksimalnu snagu panela: ");
            int snaga = Int32.Parse(Console.ReadLine());

            SolarniPanel sp = new SolarniPanel(i, snaga);

            
            using (var db = new SHESContext())
            {
                foreach (SolarniPanel panel in db.Paneli)
                {
                    if (!panel.Ime.Equals(i))
                    {
                        db.Paneli.Add(sp);
                        db.SaveChanges();
                        Console.WriteLine("Solarni panel" + sp.Ime + "uspesno dodat!");
                    }else
                        Console.WriteLine("Panel sa zadatim imenom vec postoji!");
                }
                               
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

            string i = Console.ReadLine().ToString();

            Console.WriteLine("Unesite snagu sunca za izabrani panel:");
            int s = Int32.Parse(Console.ReadLine());

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
