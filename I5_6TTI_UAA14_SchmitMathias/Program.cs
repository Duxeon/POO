using System.Numerics;

namespace I5_6TTI_UAA14_SchmitMathias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ce jeu de tir ... Vous démarrez avec 30 balles");
            Console.WriteLine("=============================================================");
            PaintBallGun[] pbg = new PaintBallGun[30];
            for (var i = 0; i < pbg.Length; i++)
            {
                pbg[i] = new PaintBallGun();
            }
            Random random = new Random();
            Player player = new Player("Luigi", pbg[random.Next(0, pbg.Length)]);
            bool q = true;
            do
            {
                if (player.MyPaintBallGun.IsVide())
                {
                    Console.WriteLine("Attention votre chargeur est vide \n");
                }
                Console.WriteLine("Espace pour tirer,\nr pour recharger,\nv pour voir combien il reste de munitions en poche et dans le chargeur,\n+ pour reprendre des munitions,\nq pour quitter\n--->");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Spacebar:
                        if (player.Tire())
                        {
                            Console.WriteLine("=> Tir effectué !");
                        }
                        else
                        {
                            Console.WriteLine("=> Echec du tir, charcheur vide");
                        }
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("=> " + player.Recharge());
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine("=> Vous avez un total de " + player.MyPaintBallGun.BallesChargeur + " cartouches dans le chargeur et " + player.NbCartoucheEnPoche + " balles dans le chargeur");
                        break;
                    case ConsoleKey.Add:
                        player.NbCartoucheEnPoche += 30;
                        Console.WriteLine("=> Reprise de 30 cartouches effectuée, vous avez un total de " + player.NbCartoucheEnPoche + " cartouches en poche.");
                        break;
                    case ConsoleKey.Q:
                        q = false;
                        break;
                    default:
                        break;
                }
            } while (q);
        }
    }
}