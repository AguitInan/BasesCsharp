// See https://aka.ms/new-console-template for more information

Console.Write("Veuillez saisir un nombre : ");
double premierNb = Convert.ToDouble(Console.ReadLine());
Console.Write("Veuillez saisir un nombre : ");
double deuxiemeNb = Convert.ToDouble(Console.ReadLine());
double resultat = premierNb + deuxiemeNb;
Console.WriteLine("La somme de ces deux nombre est : " + resultat + "\n");
Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();
