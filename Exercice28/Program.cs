
using System;

namespace Exercice28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Trouver le nombre mystère --- \n");
            Random aleatoire = new Random();
            int nbMystere = aleatoire.Next(1, 51);
            int nbCoups = 0;
            bool trouve = false;


            // Tant que le booléen trouve ne vaut pas true
            while (!trouve)
            {
                Console.Write("\tVeuillez saisir une nombre : ");
                int nbTmp = Convert.ToInt32(Console.ReadLine());
                if (nbTmp == nbMystere)
                {
                    nbCoups++;
                    trouve = true;
                }
                else if (nbTmp < nbMystere)
                {
                    nbCoups++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tLe nombre mystère est plus grand");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    nbCoups++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tLe nombre mystère est plus petit");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bravo !!!! Vous avez trouvé le nombre mystère !\n");
            Console.WriteLine("Vous avez trouvé en " + nbCoups + " coups.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Appuyez sur Entrer pour fermer le programme...");
            Console.Read();
        }
    }
}



