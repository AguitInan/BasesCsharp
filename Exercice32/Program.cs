int[] tab = new int[10];
string chaine = "";
//Random random = new Random();

Console.WriteLine("Insertion des valeurs du tableau : ");

for (int i = 0; i < tab.Length; i++)
{
    Console.Write("Saisir la valeur " + (i + 1) + " : ");
    if (int.TryParse(Console.ReadLine(), out int nombre))
    {
        tab[i] = nombre;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
        Console.ForegroundColor = ConsoleColor.White;

    }
}

Console.WriteLine("Affichage des valeurs du tableau : ");

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine(chaine + tab[i]);
    chaine += "\t";
}