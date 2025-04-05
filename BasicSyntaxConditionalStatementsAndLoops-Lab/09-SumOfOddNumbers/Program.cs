int n = int.Parse(Console.ReadLine());
int num = 1;
int sum = 0;
for (int i = 1; i <= n; i++)
{
    if (num % 2 == 1)
    {
        num = i * 2 - 1;
        Console.WriteLine(num);
    }

    sum += num;
}
Console.WriteLine($"Sum: {sum}");