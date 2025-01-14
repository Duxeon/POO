using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act10_POO_MathiasS_Biblioteque_Bis
{
    internal class Emprun
    {
        Emprunteur _emprunteur;
        Livre _livre;
        DateOnly _dateEmprun;
        int _etatDuLivre;
        bool _rendu;

        public Emprunteur Emprunteur
        {
            get { return _emprunteur; }
        }
        public Livre Livre 
        { 
            get { return _livre; } 
        }
        public DateOnly DateEmprun
        {
            get { return _dateEmprun; }
        }
        public int EtatDuLivre
        {
            get { return _etatDuLivre; }
        }
        public bool Rendu
        {
            get { return _rendu; }
        }
        public Emprun(Emprunteur emprunteur, Livre livre)
        {
            _emprunteur = emprunteur;
            _livre = livre;
            _dateEmprun = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            _etatDuLivre = livre.Etat;
            _rendu = false;
        }

        public bool Rendre()
        {
            if (_rendu)
            {
                return false;
            }
            else
            {
                _rendu = true;
                return true;
            }
        }

        public string Info()
        {
            return _emprunteur.Id + " a emprunté le " + DateEmprun + " un livre d'un état de " + EtatDuLivre + " et : " + _rendu + " a rendu\n " + _livre.ToString();
        }

    }

    internal class Emprunteur
    {
        string _id;
        public string Id 
        {
            get { return _id; }
        }
        public Emprunteur(string id)
        {
            _id = id;
        }
    }
}
