using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    public abstract class Animal
    {
        protected string _name;
        protected DateOnly _naissance;
        protected int _numeroDePuce;
        protected bool _estPourConcours;
        protected double _taille;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public DateOnly Naissance
        {
            get
            {
                return _naissance;
            }
        }
        public int NumeroDePuce
        {
            get
            {
                return _numeroDePuce;
            }
        }
        public bool EstPourConcours
        {
            get
            {
                return _estPourConcours;
            }
        }
        public double Taille
        {
            get
            {
                return _taille;
            }
        }
        public Animal(string name, DateOnly naissance, int nmr, bool concours, double taille)
        {
            _name = name;
            _naissance = naissance;
            _numeroDePuce = nmr;
            _estPourConcours = concours;
            _taille = taille;
        }

        public void Dormir()
        {
            Console.WriteLine(_name + " dort");
        }
        public void Manger()
        {
            Console.WriteLine(_name + " mange");
        }
        public virtual string GetInfo()
        {
            if (EstPourConcours)
            {
                return _name + ", le " + GetType().Name + " de numéro " + _numeroDePuce + " fait " + _taille + " cm et est un animal de concours";
            }
            return _name + ", le " + GetType().Name + " de numéro "+_numeroDePuce+" fait " + _taille + " cm";
        }
    }
    public class Chien : Animal
    {
        public Chien(string name, DateOnly naissance, int nmr, bool concours, double taille) : base(name, naissance, nmr, concours, taille)
        {

        }
        public void Aboyer()
        {
            Console.WriteLine(_name + " aboye");
        }
    }
    public class Chat : Animal
    {
        public Chat(string name, DateOnly naissance, int nmr, bool concours, double taille) : base(name, naissance, nmr, concours, taille)
        {

        }
        public void Mioler()
        {
            Console.WriteLine(_name + " miolle");
        }
    }
    public class Lapin : Animal
    {
        private double _tailleDesOreille;
        public double TailleOreille
        {
            get
            {
                return _tailleDesOreille;
            }
        }
        public Lapin(string name, DateOnly naissance, int nmr, bool concours, double taille, double tailleDesOreille) : base(name, naissance, nmr, concours, taille)
        {
            _tailleDesOreille = tailleDesOreille;
        }
        public void Bond()
        {
            Console.WriteLine(_name + " bondit !");
        }
        public override string GetInfo()
        {
            if (EstPourConcours)
            {
                return _name + ", le " + GetType().Name + " de numéro " + _numeroDePuce + " fait " + _taille + " cm, a des oreilles de "+_tailleDesOreille+" cm et est un animal de concours";
            }
            return _name + ", le " + GetType().Name + " de numéro " + _numeroDePuce + " fait " + _taille + " cm, a des oreilles de "+_tailleDesOreille+" cm";
        }
    }
}
