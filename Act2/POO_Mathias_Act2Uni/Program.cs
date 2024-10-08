using POO_Mathias_Act2._2;
using POO_Mathias_Act2._3;
using POO_MathiasS_Act2._2;
using POO_MathiasS_Act4;

namespace POO_Mathias_Act2Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle t;
            string g = "";
            double ce;

            double i;
            double r;
            complexe[] c = new complexe[2];

            Console.WriteLine("Hello, World!");
            SandwichMaker sm = new SandwichMaker();

            Personne[] p = new Personne[2];
            string nom;
            double richesse;

            int lire;
            while (true)
            {
                Console.WriteLine("1 = Cerlce, 2 = Complexes, 3 = Sandwich, 4 = Transactions");
                lire = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (lire)
                {
                    case 1:
                        Console.WriteLine("Quel est le rayon ?");
                        Console.WriteLine();
                        ce = double.Parse(Console.ReadLine());
                        t = new Cercle(ce);
                        Console.WriteLine("Le cercle de rayon " + ce + " a un périmètre de " + t.CalculePerimetre() + " et une aire de " + t.CalculeAire() + ".");
                        g = Console.ReadLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Entrer un premier complexe ");
                        Console.WriteLine("Que caut la partie réel ?");
                        r = double.Parse(Console.ReadLine());

                        Console.WriteLine("Que caut la partie imaginaire ?");
                        i = double.Parse(Console.ReadLine());

                        c[0] = new complexe(r, i);

                        Console.WriteLine("Le premier nombre complexe : " + c[0].AfficheComplexe() + " a pour module " + c[0].Module());

                        Console.WriteLine("");
                        Console.WriteLine("Entrer un second complexe ");
                        Console.WriteLine("Que caut la partie réel ?");
                        r = double.Parse(Console.ReadLine());

                        Console.WriteLine("Que caut la partie imaginaire ?");
                        i = double.Parse(Console.ReadLine());

                        c[1] = new complexe(r, i);

                        Console.WriteLine("Le second nombre complexe : " + c[1].AfficheComplexe() + " a pour module " + c[1].Module());
                        c[0].Addition(c[1]);

                        Console.WriteLine("La somme des deux complexe : " + c[0].AfficheComplexe() + " a pour module " + c[0].Module());
                        break;
                    case 3:
                        Console.WriteLine(sm.composeSandwich());
                        Console.ReadLine();
                        break;
                    case 4:
                        for (int j = 0; j <= 1; j++)
                        {
                            Console.WriteLine("Quel est le nom de la personne " + j);
                            nom = Console.ReadLine();
                            Console.WriteLine("Quel est la richesse de la personne " + j);
                            richesse = double.Parse(Console.ReadLine());
                            p[j] = new Personne(nom, richesse);
                        }
                        Console.WriteLine(p[0].Retour());
                        Console.WriteLine(p[1].Retour());
                        while (g == "")
                        {

                            for (int j = 0; j <= 1; j++)
                            {
                                Console.WriteLine("donner combien à " + p[j].Nom);
                                richesse = double.Parse(Console.ReadLine());
                                if (p[j].Richesse + richesse < 0)
                                {
                                    Console.WriteLine("Vous n'avez pas assez pour cette transaction");
                                }
                                else
                                {
                                    p[j].Richesse += richesse;
                                }
                            }

                            Console.WriteLine(p[0].Retour());
                            Console.WriteLine(p[1].Retour());
                            Console.WriteLine("Voulez-vous une nouvelle transaction ? n'écrivez rien pour recommencer");
                        }
                        break;
                }
            }
        }
    }
}
