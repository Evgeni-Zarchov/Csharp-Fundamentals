﻿int n = int.Parse(Console.ReadLine());
double totalPrice = 0;
for (int i = 1; i <= n; i++)
{

    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());
    double currentPrice = (days * capsuleCount) * pricePerCapsule;

    totalPrice += currentPrice;
    Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");

}
Console.WriteLine($"Total: ${totalPrice:f2}");