using DodavanjePanela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHES
{
    class Program
    {
        static void Main(string[] args)
        {
            string pom = "";

            Console.WriteLine("Izaberite opciju:");
            pom = Console.ReadLine();
            int x = Int32.Parse(pom);

            Console.WriteLine("1. Dodaj novi panel");
            Console.WriteLine("2. Dodaj bateriju");
            Console.WriteLine("3. Izlaz");

            switch (x)
            {
                case 1:
                    dodavanjePanelaForm dp = new dodavanjePanelaForm();

                    dp.Show();
                    break;
           
                default:
                    break;
            }



        }
    }
}
