using System.Globalization;

namespace Act10_POO_MathiasS_Biblioteque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livre> livres = new List<Livre>();
            Biblioteque namur = new Biblioteque();
            Biblioteque saintServais = new Biblioteque();
            for (int i = 0; i < 2;)
            {
                Console.WriteLine("0 = créer Livre, 1 = ajouter livre to biblioteque, 2 = delabrer livre, 3 = remove les livres delabrer");
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
                                Console.WriteLine(j + " : " + namur.Livres[j- livres.Count].Description());
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
                                    namur.Livres[b- livres.Count].Degrade();
                                    Console.WriteLine("Livre Dégradé");
                                }
                                else if (b < livres.Count + namur.Livres.Count + saintServais.Livres.Count)
                                {
                                    saintServais.Livres[b-livres.Count-namur.Livres.Count].Degrade();
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
                        default:
                            break;
                    }
                }
            }
        }
    }
}
