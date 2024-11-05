using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }
        public bool GPS
        {
            get { return _gps; }
            set { _gps = value; }
        }

        public Voiture(string modele, string marque, string couleur, int prix, string motorisation, bool gps) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public override string Affiche()
        {
            string gps = "n'a pas de gps";
            if (_gps)
            {
                gps = "a un gps";
            }
            return "cette voiture est de modèle " + _marque + " " + _couleur + "de la marque " + _marque + "et " + gps + ". Il coute " + _prix + "€. C'est une " + _motorisation;
        }
    }
}
