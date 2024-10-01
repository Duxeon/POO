namespace POO_Mathias_Act2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SandwichMaker sm = new SandwichMaker();
            while (true)
            {
                Console.WriteLine(sm.composeSandwich());
                Console.ReadLine();
            }
        }
    }
}
