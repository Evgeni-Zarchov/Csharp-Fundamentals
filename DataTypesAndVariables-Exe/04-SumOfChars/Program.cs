﻿int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    char chars = char.Parse(Console.ReadLine());
    sum += chars;
}
Console.WriteLine($"The sum equals: {sum}");