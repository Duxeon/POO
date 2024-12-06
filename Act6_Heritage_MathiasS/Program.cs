using System;

namespace Act6_Heritage_MathiasS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisissez un programme : v = Véhicule, a = animal, p = Parallellépipède, e = Employer, t = Vehicle");
            switch (Console.ReadLine()[0])
            {
                case 'v':
                    Vehicule();
                    break;
                case 'a':
                    Animal();
                    break;
                case 'p':
                    Parallellepipede();
                    break;
                case 'e':
                    Employer();
                    break;
                case 't':
                    Vehicle();
                    break;
            }
        }
        static void Vehicule()
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
                A[i] = new Voiture(mod, mar, couleur, rn.Next(0, 1000000), plus, true);
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
        static void Animal()
        {
            Animal[] spa = new Animal[5];
            spa[0] = new Chien("Agwa", new DateOnly(), 0, true, 50.2);
            spa[1] = new Chien("Naie", new DateOnly(), 1, false, 0.2);
            spa[2] = new Chat("Satan", new DateOnly(), 2, false, 50.2);
            spa[3] = new Chat("Macron", new DateOnly(), 3, true, 1.79);
            spa[4] = new Lapin("2024", new DateOnly(), 2024, true, 2024, 2);

            do
            {
                foreach (var item in spa) Console.WriteLine(item.GetInfo());
                Console.WriteLine("\n Quel animal vouler-vous vérifier ?");
                int c = int.Parse(Console.ReadLine());
                if (spa[c] is Chien chien)
                {
                    Console.WriteLine("\n 1=mange, 2=dors, 3=aboye");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            chien.Manger();
                            break;
                        case "2":
                            chien.Dormir();
                            break;
                        case "3":
                            chien.Aboyer();
                            break;
                    }
                } else if (spa[c] is Chat chat)
                {
                    Console.WriteLine("\n 1=mange, 2=dors, 3=miaule");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            chat.Manger();
                            break;
                        case "2":
                            chat.Dormir();
                            break;
                        case "3":
                            chat.Mioler();
                            break;
                    }
                } else if (spa[c] is Lapin lapin)
                {
                    Console.WriteLine("\n 1=mange, 2=dors, 3=bondit");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            lapin.Manger();
                            break;
                        case "2":
                            lapin.Dormir();
                            break;
                        case "3":
                            lapin.Bond();
                            break;
                    }
                }
            } while (true);
        }
        static void Parallellepipede()
        {

            bool continuer = true; string color;
            List<Parallelepipede> list = new List<Parallelepipede>();
            do
            {
                Console.WriteLine("0 = Carré, 1 = Rectangle");
                if (Console.ReadKey().Key == ConsoleKey.NumPad0 || Console.ReadKey().Key == ConsoleKey.D0)
                {
                    Console.WriteLine("Entrer la Couleur");
                    color = Console.ReadLine();
                    Console.WriteLine("Entrer la longueur d'un coté");
                    list.Add(new Care(double.Parse(Console.ReadLine()), color));
                    Console.WriteLine(list[list.Count - 1].CalcAire() + " cm2");
                    Console.WriteLine(list[list.Count - 1].CalcPerimetre() + " cm");
                }
                else if (Console.ReadKey().Key == ConsoleKey.NumPad1 || Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Entrer la Couleur");
                    color = Console.ReadLine();
                    Console.WriteLine("Entrer la longueur du long coté puis du court");
                    list.Add(new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), color));
                    Console.WriteLine(list[list.Count - 1].CalcAire() + " cm2");
                    Console.WriteLine(list[list.Count - 1].CalcPerimetre() + " cm");
                }
                else
                {
                    continuer = false;
                }
            } while (continuer);
        }
        static void Employer()
        {
            Employer[] employer = new Employer[10]
            {
                new Ouvrier(9, "De Wever", "Bob", new DateOnly(1111, 11, 11), new DateTime(2009, 11, 11)),
                new Ouvrier(8, "Risitas", "Jésus", new DateOnly(1234, 1, 1), new DateTime(1567, 1, 1)),
                new Ouvrier(7, "Dieudonné", "Gérard", new DateOnly(1, 12, 25), new DateTime(1, 12, 03)),
                new Ouvrier(6, "Risitas", "Jésus", new DateOnly(1234, 1, 1), new DateTime(1567, 1, 1)),
                new Ouvrier(5, "Risitas", "Jésus", new DateOnly(1234, 1, 1), new DateTime(1567, 1, 1)),
                new Cadre(4, "Satan", "Emmanuel", new DateOnly(2023, 12, 03), 3),
                new Cadre(3, "Borne", "Louise", new DateOnly(2023, 12, 03), 3),
                new Cadre(2, "Barnier", "Benito", new DateOnly(2023, 12, 03), 3),
                new Directeur(1, "Bouchez", "Louis-Phillipe", new DateOnly(2023, 12, 03), 2147483647),
                new Directeur(0, "Macron", "Adolph", new DateOnly(1456, 11, 11), 2147483647),
            };
            foreach (var item in employer)
            {
                Console.WriteLine(item.Caract());

            }
        }
        static void Vehicle()
        {
            List<Vehicle> list = new List<Vehicle>();
            do
            {
                Console.WriteLine("Que voulez-vous ? v = voiture, c = camion, b = bateau, a = avion");
                char c = Console.ReadLine()[0];
                Console.WriteLine("Entrez la marque");
                string marque = Console.ReadLine();
                Console.WriteLine("Entrez le fuel (sans virgule)");
                int fuel = int.Parse(Console.ReadLine());
                int km; 
                double tn;
                switch (c)
                {
                    case 'a':
                        Console.WriteLine("Entrez la portée");
                        double range = double.Parse(Console.ReadLine());
                        list.Add(new Plane(marque, fuel, range));
                        break;
                    case 'b':
                        Console.WriteLine("Entrez le tonnage");
                        tn = double.Parse(Console.ReadLine());
                        list.Add(new Boat(marque, fuel, tn));
                        break;
                    case 'v':
                        Console.WriteLine("Entrez le kilometrage (sans virgule)");
                        km = int.Parse(Console.ReadLine());
                        list.Add(new Car(marque, fuel, km));
                        break;
                    case 'c':
                        Console.WriteLine("Entrez le kilometrage (sans virgule)");
                        km = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entrez le tonnage");
                        tn = double.Parse(Console.ReadLine());
                        list.Add(new Truck(marque, fuel, km, tn));
                        break;
                }
            } while (true);
        }
    }
}
