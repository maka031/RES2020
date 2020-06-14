using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class ElektroDistribucija
    {
        private int snagaRazmene;
        private int cena;

        public int SnagaRazmene { get => snagaRazmene; set => snagaRazmene = value; }
        public int Cena { get => cena; set => cena = value; }
    }
}
