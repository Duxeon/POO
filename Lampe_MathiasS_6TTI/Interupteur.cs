using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampe_MathiasS_6TTI
{
    internal class Interupteur
    {
        private int _code;
        public Interupteur(int code)
        {
            _code = code;
        }

        public void Allumation(Lampe[] lampe)
        {
            lampe[_code].Lumiere = !lampe[_code].Lumiere;
        }
    }
}
