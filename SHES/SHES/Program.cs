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
                string pom = "";

                Console.WriteLine("Izaberite opciju:");
                Console.WriteLine("1. Dodaj novi panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izmeni snagu sunca:");
                Console.WriteLine("4. Dodaj potrosac:");
                Console.WriteLine("0. Izlaz");
                pom = Console.ReadLine();
                int x = Int32.Parse(pom);
                Metode m = new Metode();

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Unesite ime panela: ");
                        string i = Console.ReadLine();

                        Console.WriteLine("Unesite maksimalnu snagu panela: ");
                        int snaga = Int32.Parse(Console.ReadLine());

                        m.dodavanjeSolarnogPanela(i, snaga);


                        break;
                    case 2:
                        Console.WriteLine("Unesite ime baterije:");
                        string baterijaIme = Console.ReadLine();

                        Console.WriteLine("Unesite maksimalnu snagu baterije:");
                        int maxSnaga = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Unesite kapacitet baterije:");
                        int kapacitet = Int32.Parse(Console.ReadLine());

                        m.dodavanjeBaterije(baterijaIme, maxSnaga, kapacitet);

                        break;
                    case 3:
                        Thread t = new Thread(m.snagaSunca);
                        t.Start();
                        

                        break;
                    case 4:
                        

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
