// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- La lettre est-elle une voyelle ? --- \n");
Console.Write("Entrez une lettre : ");
string lettre = Console.ReadLine().ToUpper();
if (lettre == "A" || lettre == "E" || lettre == "I" || lettre == "O" || lettre == "U" || lettre == "Y")
    Console.WriteLine("Cette lettre est une voyelle !\n");
else
    Console.WriteLine("Cette lettre est une consonne !\n");

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
