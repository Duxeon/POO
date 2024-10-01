using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MathiasS_Act2._2
{
    internal class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double CalculePerimetre()
        {
            return 2 * Math.PI * _rayon;
        }

        public double CalculeAire()
        {
            return  Math.PI * (_rayon*_rayon);
        }
    }
}
