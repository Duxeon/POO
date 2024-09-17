using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampe_MathiasS_6TTI
{
    internal class Lampe
    {
        private string _couleur;
        private string _code;

        public bool Lumiere 
        { 
            get; 
            set; 
        }

        public Lampe(string couleur, string code)
        {
            Lumiere = false;
            _couleur = couleur;
            _code = code;
        }

        public void IsAllumee()
        {
            if (Lumiere)
            {
                if (_couleur == "Rouge")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (_couleur == "Jaune")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (_couleur == "Verte")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (_couleur == "Cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (_couleur == "Bleue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (_couleur == "Violette")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (_couleur == "Noire")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (_couleur == "Brune")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine("La lampe "+_code+" de couleur "+_couleur+" est allumée");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                    Console.WriteLine("La lampe " + _code + " de couleur " + _couleur + " est éteinte");
            }
        }
    }
}
