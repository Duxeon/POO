namespace Act7_MathiasS_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            sql.AfficheAllItems();
            do
            {
                Console.ReadLine();
                Console.Clear();
                sql.AddItem(5000000, "nom", 2500, 1, 2, "iyeaobvuhbijnvuhjbizb huijbuk", 50, "MontCuq");
                sql.AfficheAllItems();
                Console.ReadLine();
                Console.Clear();
                sql.ModifieItem(5000000, "ouïe");
                sql.AfficheAllItems();
                Console.ReadLine();
                Console.Clear();
                sql.RemItem(5000000);
                sql.AfficheAllItems();
            } while (true);
        }

    }
}
