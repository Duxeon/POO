using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act6_Heritage_MathiasS
{
    public abstract class Parallelepipede
    {
        protected double _longueur;
        protected string _color;

        public double Longueur
        {
            get { return _longueur; }
        }
        public string Color
        {
            get { return _color; }
        }
        public abstract double CalcPerimetre();
        public abstract double CalcAire();
    }
    public class Rectangle : Parallelepipede
    {
        double _largeur;
        public double Largeur
        {
            get { return _largeur; }
        }

        public Rectangle(double longueur, double largeur, string color)
        {
            _longueur = longueur;
            _largeur = largeur;
            _color = color;
        }
        public override double CalcPerimetre()
        {
            return 2*(_longueur + _largeur);
        }
        public override double CalcAire()
        {
            return _longueur * _largeur;
        }
    }
    public class Care : Parallelepipede
    {

        public Care(double longueur, string color)
        {
            _longueur = longueur;
            _color = color;
        }
        public override double CalcPerimetre()
        {
            return 4 * _longueur;
        }
        public override double CalcAire()
        {
            return Math.Pow(_longueur, 2);
        }
    }
}
