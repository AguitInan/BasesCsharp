int[] tab = new int[0];
Random rnd = new Random();

Console.WriteLine("--- Est pair...? Est impair...? ---");
Console.Write("Combiens de valeurs contiendra le tableau ? : ");
if (int.TryParse(Console.ReadLine(), out int nombre))
{
    tab = new int[nombre];
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
    Console.ForegroundColor = ConsoleColor.White;
}


Console.WriteLine("Affectation automatique des valeurs...\n");
for (int i = 0; i < tab.Length; i++)
{
    tab[i] = rnd.Next(1, 51);
}


Console.WriteLine("Vérification des valeurs du tableau : ");
for (int i = 0; i < tab.Length; i++)
{
    if (tab[i] % 2 == 0)
        Console.WriteLine("\tLa valeur " + tab[i] + " est pair.");
    else
        Console.WriteLine("\tLa valeur " + tab[i] + " est impair.");
}