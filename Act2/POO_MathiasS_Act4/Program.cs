namespace POO_MathiasS_Act4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne[] p = new Personne[2];
            string nom;
            double richesse;
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Quel est le nom de la personne " + i);
                nom = Console.ReadLine();
                Console.WriteLine("Quel est la richesse de la personne " + i);
                richesse = double.Parse(Console.ReadLine());
                p[i] = new Personne(nom, richesse);
            }
            Console.WriteLine(p[0].Retour());
            Console.WriteLine(p[1].Retour());
            while (true)
            {
                for (int i = 0; i <= 1; i++)
                {
                    Console.WriteLine("donner combien à " + p[i].Nom);
                    richesse = double.Parse(Console.ReadLine());
                    if (p[i].Richesse + richesse <0)
                    {
                        Console.WriteLine("Vous n'avez pas assez pour cette transaction");
                    } 
                    else
                    {
                    p[i].Richesse += richesse;
                    }
                }

                Console.WriteLine(p[0].Retour());
                Console.WriteLine(p[1].Retour());
            }
        }
    }
}
