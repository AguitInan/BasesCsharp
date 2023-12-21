// See https://aka.ms/new-console-template for more information
Console.Write("--- Calcul de la longeur de l'hypothénuse ---");

Console.Write("Entrez la longeur du premier coté (en cm) : ");
double premierCote = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longeur du deuxième coté (en cm) : ");
double deuxiemeCote = Convert.ToDouble(Console.ReadLine());

double sommeDesCarres = Math.Pow(premierCote, 2) + Math.Pow(deuxiemeCote, 2);
double resultat = Math.Round(Math.Sqrt(sommeDesCarres), 2);

Console.WriteLine("La longueur de l'hypoténuse est : " + resultat + " cm\n");

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();
