// See https://aka.ms/new-console-template for more information
Console.Write("Entrez le prix HT de l'objet (en Euros) : ");
double prixObjetHt = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez le taux de TVA (en %) : ");
double tauxTva = Convert.ToDouble(Console.ReadLine());

double mtTva = prixObjetHt * tauxTva / 100;
double prixObjetTtc = prixObjetHt + mtTva;
Console.WriteLine("Le montant de la T.V.A est de " + mtTva + " Euros");
Console.WriteLine("Le prix TTC de l'objet est de " + prixObjetTtc + " Euros\n");

Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
Console.Read();