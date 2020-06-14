using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponente
{
    public interface IMetode
    {
        void dodavanjeSolarnogPanela();
        void dodavanjeBaterije();
        void trenutnaSnagaPanela(string ime, int snaga);
        void snagaSunca();
       
    }
}
