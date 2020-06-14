using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SHES
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                string pom;
                Metode m = new Metode();

                Console.WriteLine("Izaberite opciju:");
                Console.WriteLine("1. Dodaj novi panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izmeni snagu sunca:");
                Console.WriteLine("4. Dodaj potrosac:");
                Console.WriteLine("0. Izlaz");
                pom = Console.ReadLine();
                Thread t = new Thread(m.snagaSunca);
                int x = Int32.Parse(pom);



                switch (x)
                {
                    case 1:                       
                        m.dodavanjeSolarnogPanela();

                        break;
                    case 2:                       
                        m.dodavanjeBaterije();

                        break;
                    case 3:
                        m.snagaSunca();
                        t.Start();
                        

                        break;
                    case 4:
                        m.dodavanjePotrosaca();

                        break;
                    case 0:
                        System.Environment.Exit(0);

                        break;
                    default:
                        break;
                }
            }



        }
    }
}
