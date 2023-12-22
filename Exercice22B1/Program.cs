using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Entrez le nombre de lignes pour la table de multiplication :");
        int rows;

        // Vérification de l'entrée pour s'assurer qu'elle est un nombre entier
        while (!int.TryParse(Console.ReadLine(), out rows) || rows < 1)
        {
            Console.WriteLine("Veuillez entrer un nombre entier positif.");
        }

        int columns = 10; // Nombre de colonnes fixe

        // Fonction pour imprimer le motif séparateur
        void PrintSeparator()
        {
            for (int i = 0; i < columns; i++)
            {
                Console.Write("+---"); 
            }
            Console.WriteLine("+"); // Fin de la ligne du motif
        }

        PrintSeparator(); // Imprimer le motif avant de commencer

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Console.Write($"|{i * j,2} "); // Affiche le produit avec un alignement
            }
            Console.WriteLine("|"); // Fermeture de la ligne
            PrintSeparator(); // Imprimer le motif après chaque ligne, y compris la dernière
        }
    }
}
