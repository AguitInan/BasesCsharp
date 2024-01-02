char[] alphabet = new char[26];
string chaine = "";

for (int i = 0; i < 26; i++)
{
    alphabet[i] = Convert.ToChar(65 + i);
}


for (int i = 0; i < 26; i++)
{
    Console.WriteLine(chaine + alphabet[i]);
    chaine += "  ";
}
