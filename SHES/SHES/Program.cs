using DodavanjePanela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnagaSunca;
using DodavanjePotrosaca;

namespace SHES
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                string pom = "";

                Console.WriteLine("Izaberite opciju:");
                Console.WriteLine("1. Dodaj novi panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izmeni snagu sunca:");
                Console.WriteLine("4. Dodaj potrosac:");
                Console.WriteLine("5. Izlaz");
                pom = Console.ReadLine();
                int x = Int32.Parse(pom);

                switch (x)
                {
                    case 1:
                        dodavanjePanelaForm dp = new dodavanjePanelaForm();
                        dp.ShowDialog();
                        break;
                    case 2:
                        Console.WriteLine("Dodavanje baterije!");
                        break;
                    case 3:
                        Metode m = new Metode();
                        SnagaSuncaForm ss = new SnagaSuncaForm();
                        ss.ShowDialog();
                        break;
                    case 4:
                        PotrosacForm pf = new PotrosacForm();
                        pf.ShowDialog();
                        break;
                    case 5:
                        Application.Exit();
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
