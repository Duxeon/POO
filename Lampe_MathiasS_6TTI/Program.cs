namespace Lampe_MathiasS_6TTI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fil;
            int erupteur;

            string color;
            string code;

            Lampe[] lampe = new Lampe[10];

            lampe[0] = new Lampe("Blanche", "0");
            lampe[1] = new Lampe("Rouge", "1");
            lampe[2] = new Lampe("Jaune", "2");
            lampe[3] = new Lampe("Verte", "3");
            lampe[4] = new Lampe("Cyan", "4");
            lampe[5] = new Lampe("Bleue", "5");
            lampe[6] = new Lampe("Violette", "6");
            lampe[7] = new Lampe("Grise", "7");
            lampe[8] = new Lampe("Brune", "8");
            lampe[9] = new Lampe("Noire", "9");


            Interupteur[] inter = new Interupteur[100];

            inter[0] = new Interupteur(0);
            inter[1] = new Interupteur(1);
            inter[2] = new Interupteur(2);
            inter[3] = new Interupteur(3);
            inter[4] = new Interupteur(4);
            inter[5] = new Interupteur(5);
            inter[6] = new Interupteur(6);
            inter[7] = new Interupteur(7);
            inter[8] = new Interupteur(8);
            inter[9] = new Interupteur(9);
            while (true)
            {
                for (int i = 0; i < lampe.Length; i++)
                {
                    lampe[i].IsAllumee();
                }
                Console.WriteLine();
                fil = Console.ReadLine();
                if (fil == "c")
                {
                    Array.Resize(ref lampe, lampe.Length + 1);
                    Array.Resize(ref inter, inter.Length + 1);
                    Console.WriteLine();
                    Console.WriteLine("Entrer la couleur de la lampe");
                    color = Console.ReadLine();
                    code = Convert.ToString(lampe.Length - 1);
                    lampe[lampe.Length - 1] = new Lampe(color, code);
                    inter[lampe.Length - 1] = new Interupteur(lampe.Length - 1);

                }
                else if (fil == "g")
                {
                    while (true)
                    {
                        for (int i = 0; i < lampe.Length; i++)
                        {
                            Thread.Sleep(50);
                            Console.SetCursorPosition(0,0);
                            inter[i].Allumation(lampe);

                            for (int j = 0; j < lampe.Length; j++)
                            {
                                lampe[j].IsAllumee();
                            }
                        }
                    }
                }
                else
                {
                    erupteur = int.Parse(fil);
                    if (erupteur < lampe.Length)
                    {
                        inter[erupteur].Allumation(lampe);
                    }
                    Console.Clear();
                }
            }
        }
    }
}