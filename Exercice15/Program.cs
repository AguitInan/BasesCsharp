// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? --- \n");
Console.Write("Merci de saisir le dernier salaire (en Euros): ");
int salaire = Convert.ToInt32(Console.ReadLine());
Console.Write("Merci de saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
int ancien = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int indemnite = 0;
if (ancien <= 10)
{
    indemnite += ancien * salaire / 2;
}
else
{
    indemnite += 10 * salaire / 2;
    indemnite += (ancien - 10) * salaire;
}
if (age > 45)
{
    if (age > 50)
    {
        indemnite += 5 * salaire;
    }
    else
    {
        indemnite += 2 * salaire;
    }
}

Console.WriteLine("Votre indemnité est de : " + indemnite + " Euros \n");
Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();
