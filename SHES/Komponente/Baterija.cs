using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class Baterija
        
    {
        private string ime;
        private int maxSnaga;
        private int kapacitet;

        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int MaxSnaga { get => maxSnaga; set => maxSnaga = value; }
        public int Kapacitet { get => kapacitet; set => kapacitet = value; }

        public Baterija()
        {
        }

        public Baterija(string ime, int maxSnaga, int kapacitet)
        {
            Ime = ime;
            MaxSnaga = maxSnaga;
            Kapacitet = kapacitet;
        }

    }
}
