﻿using System.Net;

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int sum = 0;
    int number = i;

    while (number != 0)
    {
        int digit = number % 10;
        number /= 10;
        sum += digit;
    }

    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}
