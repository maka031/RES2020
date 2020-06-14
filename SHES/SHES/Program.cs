using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

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

                Console.WriteLine("Izaberite opciju");
                Console.WriteLine("1. Dodaj novi panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izmeni snagu sunca");
                Console.WriteLine("4. Dodaj potrosac");
                Console.WriteLine("5. Statistika panela");
                Console.WriteLine("0. Izlaz");
                pom = Console.ReadLine();
                int x = Int32.Parse(pom);

                int proba = 0;

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

                        break;
                    case 4:
                        m.dodavanjePotrosaca();

                        break;
                    case 5:
                        m.merenjeSnageSolarnihPanela();
                        break;
                    case 0:
                        System.Environment.Exit(0);

                        break;
                    default:
                        break;
                }



            }


            
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Metode m = new Metode();
            m.merenjeSnageSolarnihPanela();
        }
}
}
