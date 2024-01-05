string[] moisAnnee = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
Console.WriteLine("Enumération du tableau avec un foreach :");
string chaine = "";
foreach (string Mois in moisAnnee)
{
    Console.WriteLine(chaine + Mois);
    chaine += "\t";
}
