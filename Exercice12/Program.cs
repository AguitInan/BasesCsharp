// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Dans quelle catégorie mon enfant est-il...? --- \n");
Console.Write("Entrez l'âge de votre enfant : ");

int age = int.Parse(Console.ReadLine());

if (age < 3)
{
    Console.WriteLine("Votre enfant est trop jeune");

}
else
{
    if (age >= 3 && age <= 6)
    {
        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\"");
    }
    else
    {
        if (age >= 7 && age <= 8)
        {
            Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\"");
        }
        else
        {
            if (age >= 9 && age <= 10)
            {
                Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\"");
            }
            else
            {
                if (age >= 11 && age <= 12)
                {
                    Console.WriteLine("Votre enfant est dans la catégorie \"Minime\"");
                }
                else
                {
                    if (age >= 13 && age <= 17)
                    {
                        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\"");
                    }
                    else
                    {
                        Console.WriteLine("Votre enfant est hors catégorie");
                    }
                }
            }
        }
    }
}