using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    internal class Vehicule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected int _prix;

        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Vehicule(string modele, string marque, string couleur, int prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }

        public virtual string Affiche()
        {
            return "Ce véhicule est de modèle " + _marque + " " + _couleur + "de la marque " + _marque + ". Il coute " + _prix + "€.";
        }
    }
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
