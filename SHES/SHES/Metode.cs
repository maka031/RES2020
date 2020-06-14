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
                        Console.WriteLine("Nemoguce dodati bateriju sa tim imenom!");
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
                        Console.WriteLine("Solarni panel uspesno dodat!");
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
