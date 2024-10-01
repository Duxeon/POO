namespace POO_Mathias_Act2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce programme complexe ");
            double i;
            double r;

            complexe[] c = new complexe[2];
            while (true)
            {
                Console.WriteLine("Entrer un premier complexe ");
                Console.WriteLine("Que caut la partie réel ?");
                r = double.Parse(Console.ReadLine());

                Console.WriteLine("Que caut la partie imaginaire ?");
                i = double.Parse(Console.ReadLine());

                Array.Resize(ref c, c.Length + 1);

                c[0] = new complexe(r, i);

                Console.WriteLine("Le premier nombre complexe : "+c[0].AfficheComplexe()+" a pour module " + c[0].Module());

                Console.WriteLine("");
                Console.WriteLine("Entrer un second complexe ");
                Console.WriteLine("Que caut la partie réel ?");
                r = double.Parse(Console.ReadLine());

                Console.WriteLine("Que caut la partie imaginaire ?");
                i = double.Parse(Console.ReadLine());

                Array.Resize(ref c, c.Length + 1);

                c[0] = new complexe(r, i);

                Console.WriteLine("Le second nombre complexe : " + c[0].AfficheComplexe() + " a pour module " + c[0].Module());
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}