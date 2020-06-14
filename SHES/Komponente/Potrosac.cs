using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class Potrosac
    {
        private string ime;
        private int potrosnja;

        [Key]
        public string Ime { get => ime; set => ime = value; }
        public int Potrosnja { get => potrosnja; set => potrosnja = value; }

        public Potrosac()
        {
        }

        public Potrosac(string ime, int potrosnja)
        {
            Ime = ime;
            Potrosnja = potrosnja;
        }
    }
}
