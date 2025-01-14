namespace Act10_POO_MathiasS_Biblioteque_Bis
{
    internal class Livre
    {
        string _titre;
        string _auteur;
        int _etat;

        public string Titre
        {
            get { return _titre; }
        }
        public string Auteur
        {
            get { return _auteur; }
        }
        public int Etat
        {
            get { return _etat;  }
        }

        public Livre(string titre, string auteur, int etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }

        public void Degrade()
        {
            _etat--;
        }

        public string Description()
        {
            return "Le livre " + _titre + " de " + _auteur + " a un état de " + _etat;
        }
    }

    internal class Biblioteque
    {
        List<Livre> _livres;

        public List<Livre> Livres
        {
            get { return _livres; }
        }
        public Biblioteque() { _livres = new List<Livre>(); }

        public void Add(Livre livre)
        {
            _livres.Add(livre);
        }

        public void RemoveDelabre(int maxetat)
        {
            List<Livre> listuwu = _livres.ToList();
            for (int i = 0; i < listuwu.Count; i++)
            {
                Livre? livre = listuwu[i];
                if (livre.Etat >= maxetat)
                {
                    _livres.Remove(livre);
                }
            }
        }

        public string Inventaire()
        {
            string ret = "";
            foreach (var item in _livres)
            {
                ret += item.Description() + "\n";
            }
            return ret;
        }
    }
}
