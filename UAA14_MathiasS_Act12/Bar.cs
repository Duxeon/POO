using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAA14_MathiasS_Act12
{
    class Cocktail
    {
        private string _nom;
        private List<(Ingredient, double)> _quantites;

        public string Nom
        {
            get
            {
                return _nom;
            }
        }

        public List<(Ingredient, double)> Quantites
        {
            get
            {
                return _quantites;
            }
        }

        public Cocktail(string nom, List<(Ingredient, double)> quantites)
        {
            _nom = nom;
            _quantites = quantites;
        }

        public string Afficher_recette()
        {
            string temp = "Recette du " + _nom + " :\n";
            foreach ((Ingredient, double) item in _quantites)
            {
                temp += item.Item1.Nom + ", " + (item.Item2*100) + "%; \n";
            }
            return temp;
        }
    }
    class Ingredient
    {
        private string _nom;

        public string Nom
        {
            get
            {
                return _nom;
            }
        }

        public Ingredient(string nom)
        {
            _nom = nom;
        }
    }
    class Bouteille
    {
        private Ingredient _contenu;
        private int _cl_disponible;

        public Ingredient Contenu
        {
            get
            {
                return _contenu;
            }
        }

        public Bouteille(Ingredient contenu, int cl_disponible)
        {
            _contenu = contenu;
            _cl_disponible = cl_disponible;
        }

        public string Verif_Bouteille()
        {
            return "Cette bouteille contient " + _cl_disponible + "cl de " + _contenu.Nom + ".";
        }
    }
    class Shaker
    {
        private int _capacite;
        private int _contenu;
        private Cocktail _recette;
        private bool _propre;

        public bool Propre
        {
            get
            {
                return _propre;
            }
            set
            {
                _propre = value;
            }
        }

        public Shaker()
        {
            _capacite = 20;
        }
    }
    class Bar
    {
        private List<Shaker> _shakers;
        private List<Cocktail> _menu;
        private List<Bouteille> _bouteilles;

        public List<Cocktail> Menu
        {
            get
            {
                return _menu;
            }

            set
            {
                _menu = value;
            }
        }

        public Bar(int nbr_shakers, List<Cocktail> menu)
        {
            _shakers = new List<Shaker>();
            for (int i = 0; i < nbr_shakers; i++)
            {
                _shakers.Add(new Shaker());
            }
            _menu = menu;
        }

        public bool Commander(int eeeeeuh)
        {
            if (eeeeeuh < _menu.Count)
            {
                bool temp = true;
                int shUse;
                for (int i = 0; i < _shakers.Count; i++)
                {
                    if (temp)
                    {
                        if (_shakers[i].Propre)
                        {
                            shUse = i;
                            temp = false;
                        }
                    }
                }
                if (!temp)
                {
                    bool verif = true;
                    List<(int, int)> desInts = new List<(int, int)>();
                    foreach (var item in _menu[eeeeeuh].Quantites)
                    {
                        temp = true;
                        for (int i = 0; i < _bouteilles.Count; i++)
                        {
                            if (temp)
                            {
                                if (_bouteilles[i].Contenu == item.Item1)
                                {
                                    desInts.Add((i, (int)item.Item2));
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public void GrandNettoyage()
        {
            foreach (var item in _shakers)
            {
                item.Propre = true;
            }
        }
    }
    class Client
    {
        private long _cbCard;
        private string _mail;
        public long CbCard
        {
            get
            {
                return _cbCard;
            }
        }
        public string Mail
        {
            get
            {
                return _mail;
            }
        }

        public Client(long cbCard, string mail)
        {
            _cbCard = cbCard;
            _mail = mail;
        }

        public void Spammer()
        {
            // _mail.send("Commandez dans notre super bar !!!)
        }
    }
}
