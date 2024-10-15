using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P624_SMathias
{
    internal class FeuDeSignalisation
    {
        int _couleur;
        bool _etat;
        string _identifiant;

        public bool Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
        public string Identifiant
        {
            get { return _identifiant; }
        }
        public int Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public FeuDeSignalisation(string name)
        {
            _identifiant = name;
            _etat = false;
            _couleur = 0;
        }

        public string AfficheTout()
        {
            string couleur;
            string etat;
            switch (_couleur)
            {
                case 0:
                    couleur = "Rouge";
                    break;
                case 1:
                    couleur = "Orange";
                    break;
                case 2:
                    couleur = "Vert";
                    break;
                default:
                    couleur = "Noir";
                    break;
            }
            if (_etat) 
            {
                etat = "allumé";
            }
            else
            {
                etat = "éteint";
            }
            return "Le feu de signalisation " + _identifiant + " est " + couleur + " et " + etat + ".";
        }
        public string AfficheCouleur()
        {
            string couleur;
            switch (_couleur)
            {
                case 0:
                    couleur = "Rouge";
                    break;
                case 1:
                    couleur = "Orange";
                    break;
                case 2:
                    couleur = "Vert";
                    break;
                default:
                    couleur = "Noir";
                    break;
            }
            return "Le feu de signalisation " + _identifiant + " est " + couleur + ".";
        }
        public string AfficheEtat()
        {
            string etat;
            if (_etat)
            {
                etat = "allumé";
            }
            else
            {
                etat = "éteint";
            }
            return "Le feu de signalisation " + _identifiant + " et " + etat + ".";
        }
        public void ChangeEtat()
        {
            _etat = !_etat;
        }
        public void ChangeCouleur()
        {
            if (_couleur == 0)
            {
                _couleur = 2;
            }
            else
            {
                _couleur--;
            }
        }

        public void Clignote(int nbAlt)
        {
            for (int i = 0; i < nbAlt; i++)
            {
                ChangeEtat();
                Console.WriteLine(AfficheEtat());
            }
        }
        public void ClignoteCouleur(int nbAlt)
        {
            for (int i = 0; i < nbAlt; i++)
            {
                ChangeCouleur();
                Console.WriteLine(AfficheCouleur());
            }
        }
    }
}
