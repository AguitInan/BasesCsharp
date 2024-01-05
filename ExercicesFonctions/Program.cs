using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

//string AffichageNomPrenom(string prenom, string nom)
//{
//    return prenom + " " + nom;
//}

//string chaine = AffichageNomPrenom("John", "Doe");
//Console.WriteLine(chaine);

//double Soustraire(double a, double b)
//{
//    Console.WriteLine("Je soustrais " + b + " à " + a);
//    return a - b;
//}
//double resultat = Soustraire(2, 1);
//Console.WriteLine(resultat);

//void Quelle_heure(string heure = "12h00")
//{
//    Console.WriteLine("Il est " + heure);
//}
//Quelle_heure();
//Quelle_heure("13h00");


//int Compter_lettre_a(string chaine)
//{
//    int nombreOccurences = 0;
//    foreach (char caractere in chaine)
//    {
//        if (caractere == 'a')
//        {
//            nombreOccurences++;
//        }
//    }
//    return nombreOccurences;
//}

//int Compter_lettre_a_v2(string chaine)
//{
//    int nombreOccurences = chaine.Count(c => c == 'a');

//    return nombreOccurences;
//}

//using System.Text.RegularExpressions;

//bool Verification_adn(string adn)
//{
//    bool resultatAdn = true;
//    foreach (char caractere in adn)
//    {
//        if (caractere != 'a' && caractere != 't' && caractere != 'c' && caractere != 'g')
//        {
//            resultatAdn = false;
//        }
//    }
//    return resultatAdn;
//}

//string Saisie_adn()
//{
//    Console.WriteLine("Veuillez entrer votre chaîne ADN");
//    string chaine2 = Console.ReadLine();
//    bool verifAdn = Verification_adn(chaine2);
//    if (!verifAdn)
//    {
//        chaine2 = "Chaîne ADN non valide";
//        Console.WriteLine(chaine2);
//    }
//    else
//    {
//        Console.WriteLine("Chaîne ADN valide");
//    }
//    return chaine2;
//}

//Saisie_adn();

//double Proportion(string chaineAdn, string sequenceAdn)
//{
//    //double result = 0;
//    int test = Regex.Matches(chaineAdn, sequenceAdn).Count;
//    Console.WriteLine("Occurrences : "+test);

//    double taille = chaineAdn.Length;
//    Console.WriteLine("Taille = "+taille);

//    double resultat = test / taille * 100;

//    Console.WriteLine("Résultat = "+resultat);
//    return resultat;
//}

//Proportion("aaaab", "a");
//Proportion("aaaa", "a");

(double, double, double, double) Operation(double a, double b)
{
    double somme = a + b;
    double difference = a - b;
    double quotient = a / b;
    double produit = a * b;
    return (somme, difference, quotient, produit);
}

(double a, double b, double c, double d) = Operation(10,5);

Console.WriteLine($"Somme = {a}, Différence = {b},Quotient = {c}, Produit = {d}");