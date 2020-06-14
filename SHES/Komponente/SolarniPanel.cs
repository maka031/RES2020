using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public class SolarniPanel
    {
        private string ime;
        private int maxSnaga;
        private int trenutnaSnaga;

        public List<SolarniPanel> Paneli = new List<SolarniPanel>();

        public int MaxSnaga { get => maxSnaga; set => maxSnaga = value; }
        public string Ime { get => ime; set => ime = value; }
        public int TrenutnaSnaga { get => trenutnaSnaga; set => trenutnaSnaga = value; }

        public SolarniPanel()
        {

        }
        public SolarniPanel(string i, int ms)
        {
            Ime = i;
            MaxSnaga = ms;
        }

    }
}
