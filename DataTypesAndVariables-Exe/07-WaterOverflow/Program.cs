sbyte n = sbyte.Parse(Console.ReadLine());

byte totalCapacity = 255;
int totalLitres = 0;

for (int i = 1; i <= n; i++)
{
    short currentLitres = short.Parse(Console.ReadLine());

    if (totalLitres + currentLitres <= totalCapacity)
    {
        totalLitres += currentLitres;
    }
    else
    {
        Console.WriteLine($"Insufficient capacity!");
    }
}

Console.WriteLine(totalLitres);
