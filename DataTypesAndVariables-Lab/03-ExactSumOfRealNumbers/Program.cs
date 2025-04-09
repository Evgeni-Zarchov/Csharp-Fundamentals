int n = int.Parse(Console.ReadLine());
decimal sum = 0;

for (int i = 0; i < n; i++)
{
    decimal currentNumbers = decimal.Parse(Console.ReadLine());
    sum += currentNumbers;
}

Console.WriteLine(sum);