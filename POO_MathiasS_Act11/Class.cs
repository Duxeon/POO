using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MathiasS_Act11
{
    internal class Academie
    {
        private string _nom;
        private List<Ecole> _listeEcole;

        public string Nom
        {
            get { return _nom; }
        }
        public List<Ecole> ListeEcole
        {
            get { return _listeEcole; }
        }
        public Academie(string nom)
        {
            _nom = nom;
            _listeEcole = new List<Ecole>();
        }

        public void AjouterEcole(Ecole école)
        {
            _listeEcole.Add(école);
        }
        public string AfficherEcoles()
        {
            string retour = "Liste des Écoles de l'académie '"+_nom+"' : \n";
            foreach (Ecole école in _listeEcole)
            {
                retour += école.CodeEcole + " : " + école.SiteInternet + "\n";
            }
            return retour; 
        }
    }
    internal class Ecole
    {
        string _codeEcole;
        string _siteInternet;
        List<Departement> _listeDepartement;
        
        public string CodeEcole
        {
            get { return _codeEcole; }
        }
        public string SiteInternet
        {
            get { return _siteInternet; }
        }
        public List<Departement> ListeDepartement
        {
            get { return _listeDepartement; }
        }

        public Ecole(string code, string site)
        {
            _codeEcole = code;
            _siteInternet = site;
            _listeDepartement = new List<Departement>();
        }

        public void AjouterDepartement(Departement departement)
        {
            _listeDepartement.Add(departement);
        }

        public string AfficherDepartement()
        {
            string retour = "Liste des département de "+ _codeEcole + " : \n";
            foreach (Departement item in _listeDepartement)
            {
                retour += item.Nom + ", département de " + item.Matiere;
            }
            return retour;
        }
    }
    internal class Departement
    {
        string _nom;
        string _matiere;
        List<Enseignant> _listeEnseignants;

        public string Nom
        {
            get { return _nom; }
        }
        public string Matiere
        {
            get { return _matiere; }
        }
        public List<Enseignant> ListeEnseignants
        {
            get { return _listeEnseignants; }
        }

        public Departement(string nom, string matiere)
        {
            _nom = nom;
            _matiere = matiere;
            _listeEnseignants = new List<Enseignant>();
        }

        public void AddEnseignant(Enseignant enseignant)
        {
            _listeEnseignants.Add(enseignant);
        }
    }
    internal class Enseignant : Individu
    {
        string _datePriseFonction;
        List<Cours> _listeCours;

        public Enseignant(string date, string nom, string prenom, string email, string telephone) : base(nom,  prenom,  email,  telephone)
        {
            _datePriseFonction = date;
            _listeCours = new List<Cours>();
        }
        public override string Info()
        {
            return _nom + " " + _prenom + ", prof, a pour email : " + _email + " et pour numéro de tel : " + _telephone + ". Il est arrivé le " + _datePriseFonction;
        }

    }
    abstract class Individu
    {
        protected string _nom;
        protected string _prenom;
        protected string _email;
        protected string _telephone;

        public string Nom
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public string Email
        {
            get { return _email; }
        }
        public string Telephone
        {
            get { return _telephone; }
        }
        public Individu(string nom, string prenom, string email, string telephone)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
            _telephone = telephone;
        }

        public abstract string Info();
    }
    internal class Cours
    {
        public string Nom
        {
            get { return _nom; }
        }
        public string Salle
        {
            get { return _salle; }
        }
        public int Place
        {
            get { return _place; }
        }
        string _nom;
        string _salle;
        int _place;
        List<double> _listeNotes;
        public Cours(string nom, string salle, int place)
        {
            _nom = nom;
            _salle = salle;
            _place = place;
        }
        public double CalcMoyenne()
        {
            double moyenne = 0;
            foreach (var item in _listeNotes)
            {
                moyenne += item;
            }
            return moyenne;
        }
        public void AddNote(double note)
        {
            _listeNotes.Add(note);
        }
    }
    internal class Etudiant : Individu 
    {
        DateOnly _dateEntree;
        List<(Cours, double)> _listeCours;

        public Etudiant(DateOnly date, string nom, string prenom, string email, string telephone) : base(nom, prenom, email, telephone)
        {
            _dateEntree = date;
            _listeCours = new List<(Cours, double)>();
        }

        public double CalcMoyenne()
        {
            double moyenne = 0;
            foreach(var item in _listeCours)
            {
                moyenne += item.Item2;
            }
            return moyenne/ _listeCours.Count;
        }

        public string AffMatNotees()
        {
            List<(Cours, double)> list = new List<(Cours, double)>();
            List<Cours> lsit = new List<Cours>();
            foreach (var item in _listeCours)
            {
                if (!lsit.Contains(item.Item1))
                {
                    lsit.Add(item.Item1);
                }
            }
                string retour = "Liste des cours de " + _prenom + " \n";
            foreach (var item in lsit)
            {
                retour += item.Nom + ", " + CalcMoyMatiere(item);
            }
            return retour;
        }
        public double CalcMoyMatiere(Cours cours)
        {
            double retour = 0;
            int test = 0;
            foreach (var item in _listeCours)
            {
                if (item.Item1 == cours)
                {
                    retour += item.Item2;
                    test++;
                }
            }
            if (test != 0)
            {
                return retour / test;
            }
            else
            {
                return -1;
            }
        }
        public void AddNote(double note, Cours cours)
        {
            _listeCours.Add((cours, note));
            cours.AddNote(note);
        }
        public override string Info()
        {
            return _nom + " " + _prenom + ", éleve, a pour email : " + _email + " et pour numéro de tel : " + _telephone + ". Il est arrivé le " + _dateEntree;
        }
    }
}
