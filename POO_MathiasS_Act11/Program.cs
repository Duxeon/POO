namespace POO_MathiasS_Act11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Academie> acad = new List<Academie>();
            List<Academie> cours = new List<Academie>();
            List<Academie> profs = new List<Academie>();
            List<Academie> eleves = new List<Academie>();
            do
            {
                Console.Clear();
                Console.WriteLine("0 - Nouvelle Académie");
                if (acad.Count != 0)
                {
                    for (int i = 0; i < acad.Count; i++)
                    {
                        Console.WriteLine((i+1) + " - " + acad[i].Nom);
                    }
                }

                Console.WriteLine(acad.Count + 1 + " - Élèves");
                Console.WriteLine(acad.Count + 2 + " - Profs");
                Console.WriteLine(acad.Count + 3 + " - Cours");
                int a = VerifInt();
                if (a==0)
                {
                    Console.Write("Nom de la nouvelle Académie : ");
                    string b = Console.ReadLine();
                    acad.Add(new Academie(b));
                }
                else if (a < acad.Count+1)
                {
                    a--;
                    Console.WriteLine("0 - Nouvelle École");
                    for (int i = 0; i < acad[a].ListeEcole.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + acad[a].ListeEcole[i].CodeEcole + " - " + acad[a].ListeEcole[i].SiteInternet);
                    }
                    int c = VerifInt();
                    if (c == 0)
                    {
                        Console.Write("Code de la nouvelle École : ");
                        string d = Console.ReadLine(); 
                        Console.Write("Site de la nouvelle École : ");
                        string e = Console.ReadLine();
                        acad[a].ListeEcole.Add(new Ecole(d, e));
                    }
                    else if (c < acad[a].ListeEcole.Count + 1)
                    {
                        c--;
                        Console.WriteLine("0 - Nouveau département");
                        for (int i = 0; i < acad[a].ListeEcole[c].ListeDepartement.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + acad[a].ListeEcole[c].ListeDepartement[i].Nom + " - " + acad[a].ListeEcole[c].ListeDepartement[i].Matiere);
                        }
                        int f = VerifInt();
                        if (f == 0)
                        {
                            Console.Write("Nom du nouveau département : ");
                            string g = Console.ReadLine();
                            Console.Write("Matière du nouveau département : ");
                            string h = Console.ReadLine();
                            acad[a].ListeEcole[c].ListeDepartement.Add(new Departement(g, h));
                        }
                        else if (f < acad[a].ListeEcole[c].ListeDepartement.Count + 1)
                        {
                            f--;
                            Console.WriteLine("0 - Nouveau Prof");
                            for (int i = 0; i < acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants[i].Nom + " " + acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants[i].Prenom + " - " + acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants[i].Email + " - " + acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants[i].Telephone);
                            }
                            int j = VerifInt();
                            if (j == 0)
                            {
                                Console.Write("Nom du nouveau prof : ");
                                string k = Console.ReadLine();
                                Console.Write("Prénom du nouveau prof : ");
                                string l = Console.ReadLine();
                                Console.Write("Email du nouveau prof : ");
                                string m = Console.ReadLine();
                                Console.Write("Numéro du nouveau prof : ");
                                string n = Console.ReadLine();
                                Console.Write("Date d'arrivée du nouveau prof : ");
                                acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants.Add(new Enseignant(Console.ReadLine(), k, l, m, n));
                            }
                            else if (f < acad[a].ListeEcole[c].ListeDepartement[f].ListeEnseignants.Count)
                            {
                            }
                        }
                    }
                }
                else if (a == acad.Count + 1)
                {
                    Console.WriteLine("0 - Nouvel élève");
                    if (acad.Count != 0)
                    {
                        for (int i = 0; i < acad.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + acad[i].Nom);
                        }
                    }
                }
                else if (a == acad.Count + 2)
                {

                }
                else if (a == acad.Count + 3)
                {

                }
            } while (true);
        }

        static int VerifInt()
        {
            string a;
            int b;
            do
            {
                a = Console.ReadLine();
            } while (!int.TryParse(a, out b));
            return b;
        }
    }
}