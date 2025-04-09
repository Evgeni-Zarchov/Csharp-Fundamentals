string word = "";

for (int i = 1; i <= 3; i++)
{
    char chars = char.Parse(Console.ReadLine());
    word += chars;
}

Console.WriteLine(word);