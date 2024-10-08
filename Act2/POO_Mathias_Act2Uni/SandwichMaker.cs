using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Mathias_Act2._3
{
    internal class SandwichMaker
    {
        private string[] _proteine = { "jambon", "fromage", "roast beef", "salami" };
        string[] _condiments = { "mayo", "ketchup", "fromagère", "samouraï", "eau", "sable" };
        string[] _pain = { "pain de mie", "pain blanc", "pain gris" };
        string[] _crudites = { "carrote", "salade", "tomate", "petits pois", "pomme de terre" };

        public string composeSandwich()
        {
            Random rdm = new Random();
            return _pain[rdm.Next(_pain.Length)] + "," + _proteine[rdm.Next(_proteine.Length)] + "," + _crudites[rdm.Next(_crudites.Length)] + "," + _condiments[rdm.Next(_condiments.Length)];
        }
    }
}
