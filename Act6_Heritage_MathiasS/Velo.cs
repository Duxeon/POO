using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _isElectrique;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool IsElectrique
        {
            get { return _isElectrique; }
            set { _isElectrique = value; }
        }

        public Velo(string modele, string marque, string couleur, int prix, string type, bool isElectrique) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _isElectrique = isElectrique;
        }
        public override string Affiche()
        {
            string elec;
            if (_isElectrique)
            {
                elec = "est electrique";
            }
            else
            {
                elec = "n'est pas electrique";
            }
            return "ce vélo est de type " + _type + ", de modèle " + _marque + " " + _couleur + "de la marque " + _marque + " et " + elec + ". Il coute " + _prix + "€.";
        }
    }
}
