﻿//int kolkko = int.Parse(Console.ReadLine());
//int obshto = 0;
//int takova = 0;
//bool toe = false;
//for (int ch = 1; ch <= kolkko; ch++)
//{
//    takova = ch;
//    while (ch > 0)
//    {
//        obshto += ch % 10;
//        ch = ch / 10;
//    }
//    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
//    Console.WriteLine("{0} -> {1}", takova, toe);
//    obshto = 0;
//    ch = takova;
//}
// Code to refactor.


int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int currNumber = i;
    int sum = 0;
    while (currNumber != 0)
    {
        int digit = currNumber % 10;
        sum += digit;
        currNumber /= 10;
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
// Refactored.