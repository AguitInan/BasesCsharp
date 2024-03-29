﻿int[] notes = new int[0];
double moyenne = 0;
Console.WriteLine("***** Tableaux des notes *****");
Console.Write("Combiens de notes comportera le tableaux : ");
bool ok = false;

while (!ok)
{
    if (int.TryParse(Console.ReadLine(), out int nb))
    {
        notes = new int[nb];
        ok = true;
        Console.WriteLine("");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tErreur de saisie, merci de saisir un chiffre/nombre : ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("Merci de saisir les " + notes.Length + " notes\n");

for (int i = 0; i < notes.Length; i++)
{
    Console.Write("\t-Note " + (i + 1) + " : ");
    bool valid = false;
    while (!valid)
    {
        if (int.TryParse(Console.ReadLine(), out int note))
        {
            notes[i] = note;
            valid = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tErreur, merci de saisir un chiffre/nombre pour la note " + (i + 1) + " : ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("");
Console.WriteLine("--- Liste des notes ---");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("La note " + (i + 1) + " est de : " + notes[i] + "/20");
    moyenne += notes[i];
}
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- La note max est : " + notes.Max() + "/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- La note min est : " + notes.Min() + "/20");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("--- La moyenne est de : " + Math.Round(moyenne / notes.Length, 2) + "/20\n");
Console.ForegroundColor = ConsoleColor.White;

