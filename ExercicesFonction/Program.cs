string AffichageNomPrenom (string nom, string prenom)
{
    return prenom + " " + nom;
}

string chaine = AffichageNomPrenom("Doe", "John");
Console.WriteLine(chaine);