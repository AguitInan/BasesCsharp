Console.WriteLine("--- Accroissement de population ---");
Console.WriteLine();

double nbhabitant = 96809;
int date = 2015;
int nbAnnee = 0;

for (int i = 1; i < 50; i++)
{
    nbhabitant = nbhabitant + nbhabitant * 0.0089;
    date++;
    nbAnnee++;
    if (nbhabitant >= 120000)
        break;
}

Console.WriteLine("Il faudra " + nbAnnee + " ans, nous serons en " + date);
Console.WriteLine("Il y aura " + Math.Round(nbhabitant, 0) + " habitants en " + date + "\n");
