namespace Act6_Heritage_MathiasS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture[] A = new Voiture[5];
            Velo[] B = new Velo[5];
            Random rn = new Random();
            for (int i = 0; i < 5; i++)
            {
                string mod = "mod";
                string mar = "mar";
                string couleur = "Rouge";
                string plus = "plus";
                A[i] = new Voiture(mod, mar, couleur, rn.Next(0,1000000), plus, true);
                B[i] = new Velo(mod, mar, couleur, rn.Next(0, 1000000), plus, false);
            }

            foreach (Voiture item in A)
            {
                Console.WriteLine(item.Affiche());
            }
            foreach (Velo item in B)
            {
                Console.WriteLine(item.Affiche());
            }
        }
    }
}
