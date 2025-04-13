int pokePower = int.Parse(Console.ReadLine());
int target = int.Parse(Console.ReadLine());
int exhausted = int.Parse(Console.ReadLine());
int counter = 0;
int power = pokePower;

while (pokePower >= target)
{
    pokePower -= target;
    counter++;

    if (power * 0.5 == pokePower && exhausted > 0)
    {
        pokePower /= exhausted;
    }
}
Console.WriteLine(pokePower);
Console.WriteLine(counter);
