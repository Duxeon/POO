using System.ComponentModel.Design;

namespace UAA14_MathiasS_Act12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>
{
    new Ingredient("Rhum"),
    new Ingredient("Vodka"),
    new Ingredient("Gin"),
    new Ingredient("Tequila"),
    new Ingredient("Triple sec"),
    new Ingredient("Cointreau"),
    new Ingredient("Limonade"),
    new Ingredient("Jus d'orange"),
    new Ingredient("Jus de cranberry"),
    new Ingredient("Soda")
};
            Bar bar = new Bar(5, new List<Cocktail>
{
    new Cocktail("Mojito", new List<(Ingredient, double)>
    {
        (ingredients[0], 0.5), // Rhum
        (ingredients[6], 0.3), // Limonade
        (ingredients[7], 0.2)  // Jus d'orange
    }),

    new Cocktail("Margarita", new List<(Ingredient, double)>
    {
        (ingredients[3], 0.6), // Tequila
        (ingredients[4], 0.3), // Triple sec
        (ingredients[7], 0.1)  // Jus d'orange
    }),

    new Cocktail("Cosmopolitan", new List<(Ingredient, double)>
    {
        (ingredients[2], 0.5), // Gin
        (ingredients[4], 0.4), // Cointreau
        (ingredients[8], 0.1)  // Jus de cranberry
    }),

    new Cocktail("Bloody Mary", new List<(Ingredient, double)>
    {
        (ingredients[1], 0.6), // Vodka
        (ingredients[6], 0.3), // Limonade
        (ingredients[8], 0.1)  // Jus de cranberry
    }),

    new Cocktail("Sex on the Beach", new List<(Ingredient, double)>
    {
        (ingredients[1], 0.5), // Vodka
        (ingredients[8], 0.4), // Jus de cranberry
        (ingredients[7], 0.1)  // Jus d'orange
    }),

    new Cocktail("Gin Tonic", new List<(Ingredient, double)>
    {
        (ingredients[2], 0.6), // Gin
        (ingredients[9], 0.4)  // Soda
    }),

    new Cocktail("Caipirinha", new List<(Ingredient, double)>
    {
        (ingredients[0], 0.7), // Rhum
        (ingredients[6], 0.3)  // Limonade
    }),

    new Cocktail("Long Island Iced Tea", new List<(Ingredient, double)>
    {
        (ingredients[0], 0.2), // Rhum
        (ingredients[1], 0.2), // Vodka
        (ingredients[2], 0.2), // Gin
        (ingredients[3], 0.2), // Tequila
        (ingredients[4], 0.1), // Triple sec
        (ingredients[9], 0.1)  // Soda
    }),

    new Cocktail("Piña Colada", new List<(Ingredient, double)>
    {
        (ingredients[0], 0.5), // Rhum
        (ingredients[7], 0.3), // Jus d'orange
        (ingredients[6], 0.2)  // Limonade
    }),

    new Cocktail("Tequila Sunrise", new List<(Ingredient, double)>
    {
        (ingredients[3], 0.5), // Tequila
        (ingredients[8], 0.4), // Jus de cranberry
        (ingredients[7], 0.1)  // Jus d'orange
    })
});

            List<Client> clients = new List<Client>
{
    new Client(1234567890123456, "client1@mail.com"),
    new Client(2345678901234567, "client2@mail.com"),
    new Client(3456789012345678, "client3@mail.com"),
    new Client(4567890123456789, "client4@mail.com"),
    new Client(5678901234567890, "client5@mail.com"),
    new Client(6789012345678901, "client6@mail.com"),
    new Client(7890123456789012, "client7@mail.com"),
    new Client(8901234567890123, "client8@mail.com"),
    new Client(9012345678901234, "client9@mail.com"),
    new Client(1234567890123467, "client10@mail.com"),
    new Client(2345678901234578, "client11@mail.com"),
    new Client(3456789012345689, "client12@mail.com"),
    new Client(4567890123456790, "client13@mail.com"),
    new Client(5678901234567801, "client14@mail.com"),
    new Client(6789012345678912, "client15@mail.com")
};

            do
            {
                Console.Clear();
                int i = 0;
                foreach (Cocktail item in bar.Menu)
                {
                    Console.WriteLine(i++ + " : " + item.Nom);
                }
                string premierString = Console.ReadLine();
                if (int.TryParse(premierString, out int i2))
                {
                    if (i2 < i)
                    {
                        ConsoleKeyInfo cki;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(bar.Menu[i2].Afficher_recette);
                            Console.WriteLine("Voulez-vous le commander ? Y/N");
                            cki = Console.ReadKey();
                        } while (cki.Key != ConsoleKey.Y && cki.Key != ConsoleKey.N);
                        if (cki.Key == ConsoleKey.Y)
                        {
                            if (bar.Commander(i2))
                            {
                                Console.WriteLine("Voici votre " + bar.Menu[i2]);
                            }
                            else
                            {
                                Console.WriteLine("C'est un échec");
                            }
                            Console.ReadKey();
                        }
                    }
                    else if (i2 == i)
                    {
                        foreach (var item in clients)
                        {
                            Console.WriteLine(item.CbCard + "; " + item.Mail);
                        }
                        Console.ReadKey();
                    }
                    else if (i2 == i+1)
                    {
                        foreach (var item in clients)
                        {
                            item.Spammer();
                        }
                        Console.WriteLine("Tout les clients ont été spammé par email");
                        Console.ReadKey();
                    }
                }
            } while (true);
        }
    }
}
