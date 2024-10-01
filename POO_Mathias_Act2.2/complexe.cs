using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Mathias_Act2._2
{
    internal class complexe
    {
        private double _reel;
        private double _imaginaire;

        public double Reel
        {
            get; 
            set;
        }

        public double Imaginaire
        {
            get;
            set;
        }

        public complexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public string AfficheComplexe()
        {
            return "(" + _reel + ";" + _imaginaire + ")";
        }

        public double Module()
        {
            return (Math.Sqrt((_reel*_reel)+(_imaginaire*_imaginaire)));
        }
    }
}
