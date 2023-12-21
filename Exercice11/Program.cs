Console.Write("Entrez un chiffre/nombre entier : ");
int nb = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le chiffre/nombre diviseur : ");
int div = Convert.ToInt32(Console.ReadLine());

if (nb > 9)
{
    if (nb % div == 0)
        Console.WriteLine("Le nombre est divisible par " + div);
    else
        Console.WriteLine("Le nombre n'est pas divisible par " + div);
}
else
{
    if (nb % div == 0)
        Console.WriteLine("Le chiffre est divisible par " + div);
    else
        Console.WriteLine("Le chiffre n'est pas divisible par " + div);
}