// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Quelle est la nature du triangle ABC ? --- \n");
Console.Write("Entrez la longeur du segment AB : ");
double longueurAB = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment BC : ");
double longueurBC = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment CA : ");
double longueurAC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");
if (longueurAB == longueurBC && longueurAB == longueurAC && longueurBC == longueurAC)
{
    Console.WriteLine("Le triangle est équilatéral.\n");
}
else
{
    if (longueurAB == longueurAC)
    {
        Console.WriteLine("Le triangle est isocèle en A.\n");
    }
    else
    {
        if (longueurAB == longueurBC)
        {
            Console.WriteLine("Le triangle est isocèle en B.\n");
        }
        else
        {
            if (longueurBC == longueurAC)
            {
                Console.WriteLine("Le triangle est isocèle en C.\n");
            }
            else
            {
                Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.\n");
            }
        }
    }
}
Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();
