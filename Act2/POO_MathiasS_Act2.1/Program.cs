namespace POO_MathiasS_Act2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cercle[] t = new Cercle[1000];
            string g = "";
            double c;
            for (int i = 0; i < 1000; i++)
            {
                if (g != "break")
                {
                    Console.WriteLine("Quel est le rayon ?");
                    Console.WriteLine();
                    c = double.Parse(Console.ReadLine());
                    t[i]= new Cercle(c);
                    Console.WriteLine("Le cercle de rayon " + c + " a un périmètre de " + t[i].CalculePerimetre() + " et une aire de " + t[i].CalculeAire() + ".");
                    g = Console.ReadLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                }
            }
        }
    }
}