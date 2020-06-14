using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class Podaci
    {
        private bool stanjeBaterije;
        private int snagaPanela;
        private int cenaED;
        private string proba;

        public bool StanjeBaterije { get => stanjeBaterije; set => stanjeBaterije = value; }

        [Key]
        public int CenaED { get => cenaED; set => cenaED = value; }
        public int SnagaPanela { get => snagaPanela; set => snagaPanela = value; }
    }
}
