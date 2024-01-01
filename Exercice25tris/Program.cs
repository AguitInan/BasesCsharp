using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez la hauteur du sapin de Noël :");
        int hauteurSapin;
        if (!int.TryParse(Console.ReadLine(), out hauteurSapin) || hauteurSapin < 1)
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif pour la hauteur du sapin.");
            return;
        }

        Console.WriteLine("Entrez la hauteur du tronc du sapin :");
        int hauteurTronc;
        if (!int.TryParse(Console.ReadLine(), out hauteurTronc) || hauteurTronc < 1)
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif pour la hauteur du tronc.");
            return;
        }

        Random random = new Random();

        // Construire le sapin
        for (int i = 0; i < hauteurSapin; i++)
        {
            for (int j = 0; j < hauteurSapin - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (2 * i) + 1; j++)
            {
                if (i == 0) // Condition spéciale pour le sommet du sapin
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("A");
                    Console.ResetColor();
                    break;
                }
                else if (random.NextDouble() < 0.5) // 50% de chance d'avoir une boule
                {
                    Console.ForegroundColor = (ConsoleColor)random.Next(8, 16); // Choisir une couleur aléatoire
                    Console.Write("o");
                    Console.ResetColor(); // Réinitialiser la couleur
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Les étoiles en vert
                    Console.Write("*");
                    Console.ResetColor(); // Réinitialiser la couleur
                }
            }
            Console.WriteLine();
        }

        // Construire le tronc en rouge
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < hauteurTronc; i++)
        {
            for (int j = 1; j < hauteurSapin - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("| |");
        }
        Console.ResetColor(); // Réinitialiser la couleur après le tronc
    }
}
