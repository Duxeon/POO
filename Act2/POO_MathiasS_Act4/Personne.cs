using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MathiasS_Act4
{
    internal class Personne
    {
        private string _nom;
        private double _richesse;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set 
            { 
                _nom = value; 
            }
        }
        public double Richesse
        {
            get
            {
                return _richesse;
            }
            set
            {
                if (value >= 0)
                {
                    _richesse = value;
                }
            }
        }

        public Personne(string nom, double richesse)
        {
            _nom = nom;
            _richesse = richesse;
        }

        public string Retour()
        {
            return _nom + " a " + _richesse + "$ dans son portefeuille";
        }
    }
}
