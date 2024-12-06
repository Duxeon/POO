using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    public abstract class Employer
    {
        protected int _matricule;
        protected string _nom, _prenom;
        protected DateOnly _dateDeNaissance;
        public Employer(int matricule, string nom, string prenom, DateOnly dateDeNaissance)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _dateDeNaissance = dateDeNaissance;
        }

        public abstract string Caract();
    }

    public class Ouvrier : Employer
    {
        int _baseSalaire = 2500;
        DateTime _dateArrive;
        public Ouvrier(int matricule, string nom, string prenom, DateOnly dateDeNaissance, DateTime dateArrive) : base(matricule, nom, prenom, dateDeNaissance)
        {
            _dateArrive = dateArrive;
        }
        public override string Caract() 
        {
            return _matricule + ", du nom de " + _prenom + " " + _nom + " est née le " + _dateDeNaissance + " et est arrivé le " + _dateArrive;
        }
        public double Salaire()
        {
            if ((_baseSalaire + 100 * (((_dateArrive - DateTime.Today)).TotalDays)/365) >= 2 * _baseSalaire) return 2 * _baseSalaire;
            else return (_baseSalaire + 100 * (((_dateArrive - DateTime.Today)).TotalDays)/365);
        }
    }
    public class Cadre : Employer 
    {
        int _indice;
        public Cadre(int matricule, string nom, string prenom, DateOnly dateDeNaissance, int indice) : base(matricule, nom, prenom, dateDeNaissance)
        {
            _indice = indice;
        }
        public override string Caract()
        {
            return _matricule + ", du nom de " + _prenom + " " + _nom + " est née le " + _dateDeNaissance + " et est d'indice " + _indice;
        }
        public double Salaire()
        {
            switch (_indice)
            {
                case 1:
                    return 13000;
                case 2:
                    return 15000;
                case 3:
                    return 17000;
                case 4:
                    return 20000;
                default:
                    return 0;
            }
        }
    }
    public class Directeur : Employer
    {
        int _ca;
        public Directeur(int matricule, string nom, string prenom, DateOnly dateDeNaissance, int indice) : base(matricule, nom, prenom, dateDeNaissance)
        {
            _ca = indice;
        }
        public override string Caract()
        {
            return _matricule + ", du nom de  " + _prenom + " " + _nom + " est née le " + _dateDeNaissance;
        }
        public double Salaire(int nbrDirecteur)
        {
            return _ca / 2;
        }
    }
}
