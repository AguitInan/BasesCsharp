Console.WriteLine("--- Quelle est la nature du triangle ABC ? --- \n");
Console.Write("Entrez la longeur du segment AB : ");
double longueurAB = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment BC : ");
double longueurBC = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longeur du segment CA : ");
double longueurAC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");
if (longueurAB == longueurBC && longueurAB == longueurAC && longueurAC == longueurBC)
{
    Console.WriteLine("Le triangle est équilatéral.\n");
}
else
{
    if (longueurAB == longueurAC)
    {
        Console.WriteLine("Le triangle est isocèle en A mais pas équilatéral.");
    }
    else
    {
        if (longueurAB == longueurBC)
        {
            Console.WriteLine("Le triangle est isocèle en B mais pas équilatéral.");
        }
        else
        {
            if (longueurAC == longueurBC)
            {
                Console.WriteLine("Le triangle est isocèle en C mais pas équilatéral.");
            }
            else
            {
                Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C.");
            }
        }
    }
}