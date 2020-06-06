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
            while (true)
            {


                string pom = "";


                Console.WriteLine("Izaberite opciju:");
                Console.WriteLine("1. Dodaj novi panel");
                Console.WriteLine("2. Dodaj bateriju");
                Console.WriteLine("3. Izlaz");
                pom = Console.ReadLine();
                int x = Int32.Parse(pom);



                switch (x)
                {
                    case 1:
                        dodavanjePanelaForm dp = new dodavanjePanelaForm();

                        dp.ShowDialog();

                        break;

                    default:
                        break;
                }
            }



        }
    }
}
