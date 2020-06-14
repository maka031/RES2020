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
        public void dodavanjeBaterije(string i, int ms, int k)
        {
            Baterija bat = new Baterija(i, ms, k);

            using (var db = new SHESContext())
            {
                foreach (Baterija b in db.Baterije)
                {
                    if (!b.Ime.Equals(i))
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

        public void dodavanjeSolarnogPanela(string i, int ms)
        {
            SolarniPanel sp = new SolarniPanel(i, ms);

            
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

        public void trenutnaSnagaPanela(string ime, int snaga)
        {
            
        }
    }
}
