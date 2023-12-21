// See https://aka.ms/new-console-template for more information

Console.Write("Entrez un chiffre/nombre entier : ");
int nombre = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le chiffre/nombre diviseur : ");
int diviseur = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
if (nombre > 9)
{
    if (nombre % diviseur == 0)
        Console.WriteLine("Le nombre est divisible par " + diviseur + "\n");
    else
        Console.WriteLine("Le nombre n'est pas divisible par " + diviseur + "\n");
}
else
{
    if (nombre % diviseur == 0)
        Console.WriteLine("Le chiffre est divisible par " + diviseur + "\n");
    else
        Console.WriteLine("Le chiffre n'est pas divisible par " + diviseur + "\n");
}