namespace I2P624_SMathias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuDeSignalisation[] fire = new FeuDeSignalisation[2];
            fire[0] = new FeuDeSignalisation("001");
            fire[1] = new FeuDeSignalisation("002");
            while (true)
            {
                Console.WriteLine("Etat et couleur des feux : ");
                Console.WriteLine("------------------------------------------------------------");
                for (int i = 0; i < fire.Length; i++)
                {
                    Console.WriteLine(fire[i].AfficheTout());
                }
                Console.WriteLine("");
                Console.WriteLine("Faire Passer le 002 à l'Orange : ");
                Console.WriteLine("------------------------------------------------------------");
                fire[1].ChangeCouleur(); fire[1].ChangeCouleur(); fire[1].ChangeEtat(); Console.WriteLine(fire[1].AfficheTout());
                Console.WriteLine("Feu Clignotant : ");
                Console.WriteLine("---------------------");
                fire[1].Clignote(5);
                Console.WriteLine("Changement de Couleur : ");
                Console.WriteLine("---------------------");
                fire[0].ClignoteCouleur(4);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
