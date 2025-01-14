namespace Act10_POO_MathiasS_Biblioteque_Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livre> livres = new List<Livre>();
            Biblioteque namur = new Biblioteque();
            Biblioteque saintServais = new Biblioteque();
            List<Emprunteur> emprunteurs = new List<Emprunteur>();
            List<Emprun> empruns = new List<Emprun>();
            for (int i = 0; i < 2;)
            {
                Console.WriteLine("0 = créer Livre, 1 = ajouter livre to biblioteque, 2 = delabrer livre, 3 = remove les livres delabrer, 4 = ajouter un emprunteur, 5 = emprunter, 6 = fin d'emprun, 7 = Liste des empruns");
                string am = Console.ReadLine();
                if (int.TryParse(am, out int a))
                {
                    switch (a)
                    {
                        case 0:
                            string bt = Console.ReadLine();
                            string ba = Console.ReadLine();
                            string bem = Console.ReadLine();
                            Console.Clear();
                            if (int.TryParse(bem, out int be))
                            {
                                livres.Add(new Livre(bt, ba, be));
                                Console.WriteLine("Livre Créer");
                            }
                            break;
                        case 1:
                            for (int j = 0; j < livres.Count; j++)
                            {
                                Console.WriteLine(j + " : " + livres[j].Description());
                            }
                            if (int.TryParse(Console.ReadLine(), out int bn))
                            {
                                if (bn < livres.Count)
                                {
                                    Console.WriteLine("n = Namur, autre = Saint-Servais");
                                    if ("N" == Console.ReadLine().ToUpper())
                                    {
                                        Console.Clear();
                                        namur.Add(livres[bn]);
                                        livres.Remove(livres[bn]);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        saintServais.Add(livres[bn]);
                                        livres.Remove(livres[bn]);
                                    }
                                    Console.WriteLine("Livre Ajouté");
                                }
                            }
                            break;
                        case 2:
                            for (int j = 0; j < livres.Count; j++)
                            {
                                Console.WriteLine(j + " : " + livres[j].Description());
                            }
                            Console.WriteLine("\nNamur");
                            for (int j = livres.Count; j < (livres.Count + namur.Livres.Count); j++)
                            {
                                Console.WriteLine(j + " : " + namur.Livres[j - livres.Count].Description());
                            }
                            Console.WriteLine("\nSaint-Servais");
                            for (int j = livres.Count + namur.Livres.Count; j < (livres.Count + namur.Livres.Count + saintServais.Livres.Count); j++)
                            {
                                Console.WriteLine(j + " : " + livres[j - livres.Count - namur.Livres.Count].Description());
                            }

                            if (int.TryParse(Console.ReadLine(), out int b))
                            {
                                Console.Clear();
                                if (b < livres.Count)
                                {
                                    livres[b].Degrade();
                                    Console.WriteLine("Livre Dégradé");
                                }
                                else if (b < livres.Count + namur.Livres.Count)
                                {
                                    namur.Livres[b - livres.Count].Degrade();
                                    Console.WriteLine("Livre Dégradé");
                                }
                                else if (b < livres.Count + namur.Livres.Count + saintServais.Livres.Count)
                                {
                                    saintServais.Livres[b - livres.Count - namur.Livres.Count].Degrade();
                                    Console.WriteLine("Livre Dégradé");
                                }
                            }
                            break;
                        case 3:
                            if (int.TryParse(Console.ReadLine(), out int g))
                            {
                                namur.RemoveDelabre(g);
                                saintServais.RemoveDelabre(g);
                                Console.Clear();
                                Console.WriteLine("Livres Dégradés supprimés");
                            }
                            break;
                        case 4:
                            string id = Console.ReadLine();
                            Console.Clear();
                            emprunteurs.Add(new Emprunteur(id));
                            break;
                        case 5:

                            for (int j = 0; j < emprunteurs.Count; j++)
                            {
                                Console.WriteLine(j + " : " + emprunteurs[j].Id);
                            }
                            if (int.TryParse(Console.ReadLine(), out int bid))
                            {
                                for (int j = 0; j < livres.Count; j++)
                                {
                                    Console.WriteLine(j + " : " + livres[j].Description());
                                }
                                Console.WriteLine("\nNamur");
                                for (int j = livres.Count; j < (livres.Count + namur.Livres.Count); j++)
                                {
                                    Console.WriteLine(j + " : " + namur.Livres[j - livres.Count].Description());
                                }
                                Console.WriteLine("\nSaint-Servais");
                                for (int j = livres.Count + namur.Livres.Count; j < (livres.Count + namur.Livres.Count + saintServais.Livres.Count); j++)
                                {
                                    Console.WriteLine(j + " : " + livres[j - livres.Count - namur.Livres.Count].Description());
                                }

                                if (int.TryParse(Console.ReadLine(), out int bub))
                                {
                                    Console.Clear();
                                    if (bub < livres.Count)
                                    {
                                        empruns.Add(new Emprun(emprunteurs[bid], livres[bub]));
                                        Console.WriteLine("Livre Emprunté");
                                    }
                                    else if (bub < livres.Count + namur.Livres.Count)
                                    {
                                        empruns.Add(new Emprun(emprunteurs[bid], livres[bub - livres.Count]));
                                        Console.WriteLine("Livre Emprunté");
                                    }
                                    else if (bub < livres.Count + namur.Livres.Count + saintServais.Livres.Count)
                                    {
                                        empruns.Add(new Emprun(emprunteurs[bid], livres[bub - livres.Count - namur.Livres.Count]));
                                        Console.WriteLine("Livre Emprunté");
                                    }
                                }
                            }
                            break;
                        case 6:
                            for (int j = 0; j < empruns.Count; j++)
                            {
                                Console.WriteLine(j + " : " + empruns[j].Info());
                            }
                            if (int.TryParse(Console.ReadLine(), out int bun))
                            {
                                if (bun < empruns.Count)
                                {
                                    if (empruns[bun].Rendre())
                                    {
                                        Console.WriteLine("Livre rendu");
                                    }
                                }
                            }
                                break;
                        case 7:
                            for (int j = 0; j < empruns.Count; j++)
                            {
                                if (!empruns[j].Rendu)
                                {
                                    Console.WriteLine(j + " : " + empruns[j].Info());
                                }
                            }
                            Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
