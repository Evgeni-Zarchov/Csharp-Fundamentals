﻿int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine(sum);
