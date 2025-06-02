using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu du devin !");
            Console.WriteLine("Choisissez un niveau :");
            Console.WriteLine("1. Débutant (1-10)");
            Console.WriteLine("2. Intermédiaire (1-50)");
            Console.WriteLine("3. Expert (1-100)");
            int niveau = int.Parse(Console.ReadLine());
            int min, max;
            switch (niveau)
            {
                case 1:
                    min = 1;
                    max = 10;
                    break;
                case 2:
                    min = 1;
                    max = 50;
                    break;
                case 3:
                    min = 1;
                    max = 100;
                    break;
                default:
                    min = 1;
                    max = 100;
                    break;
            }
            Random rand = new Random();
            int nombreATrouver = rand.Next(min, max + 1);
            int nombreDEssais = 0;
            List<int> propositionsPetites = new List<int>();
            List<int> propositionsGrandes = new List<int>();
            bool aide = false;
            if (niveau > 1)
            {
                Console.WriteLine("Voulez-vous de l'aide ? (o/n)");
                if (Console.ReadLine().ToLower() == "o")
                {
                    aide = true;
                }
            }
            while (true)
            {
                Console.WriteLine("Entrez un nombre entre " + min + " et " + max + " :");
                int proposition = int.Parse(Console.ReadLine());
                if (proposition < min || proposition > max)
                {
                    Console.WriteLine("Le nombre doit être compris entre " + min + " et " + max + ".");
                    continue;
                }
                nombreDEssais++;
                if (proposition < nombreATrouver)
                {
                    propositionsPetites.Add(proposition);
                    Console.WriteLine("Plus grand !");
                    if (aide)
                    {
                        Console.WriteLine("Nombres plus petits : " + string.Join(", ", propositionsPetites));
                    }
                }
                else if (proposition > nombreATrouver)
                {
                    propositionsGrandes.Add(proposition);
                    Console.WriteLine("Plus petit !");
                    if (aide)
                    {
                        Console.WriteLine("Nombres plus grands : " + string.Join(", ", propositionsGrandes));
                    }
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre en " + nombreDEssais + " essais !");
                    break;
                }
                if (niveau > 1 && nombreDEssais >= 10)
                {
                    Console.WriteLine("Vous avez atteint le nombre maximum d'essais. Le nombre à trouver était " + nombreATrouver + ".");
                    break;
                }
                if (niveau > 1 && aide)
                {
                    Console.WriteLine("Voulez-vous un bonus supplémentaire ? (o/n)");
                    if (Console.ReadLine().ToLower() == "o")
                    {
                        int ecart = Math.Abs(proposition - nombreATrouver);
                        if (ecart <= 5)
                        {
                            Console.WriteLine("Brûlante !");
                        }
                        else if (ecart <= 10)
                        {
                            Console.WriteLine("Chaude !");
                        }
                        else if (ecart <= 20)
                        {
                            Console.WriteLine("Froide !");
                        }
                        else
                        {
                            Console.WriteLine("Gelée !");
                        }
                        nombreDEssais--;
                    }
                }
            }
        }
    }
}
