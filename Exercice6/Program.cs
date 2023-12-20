// See https://aka.ms/new-console-template for more information

Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");

Console.Write("Entrez la longueur d'un coté du carré (en cm) : ");
double longueurCote = Convert.ToDouble(Console.ReadLine());

double perimetre = longueurCote * 4;
double aire = longueurCote * longueurCote;

Console.WriteLine("Le périmètre du carré est : " + perimetre + " cm");
Console.WriteLine("L'aire du carré est : " + aire + " cm2\n");


Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");

Console.Write("Entrez la longueur du rectangle (en cm) : ");
double longueurRectangle = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la largeur du rectangle (en cm) : ");
double largeurRectangle = Convert.ToDouble(Console.ReadLine());

double perimetreRectangle = (longueurRectangle + largeurRectangle) * 2;
double aireRectangle = longueurRectangle * largeurRectangle;

Console.WriteLine("Le périmètre du rectangle est : " + perimetreRectangle + " cm");
Console.WriteLine("L'aire du rectangle est : " + aireRectangle + " cm2\n");

