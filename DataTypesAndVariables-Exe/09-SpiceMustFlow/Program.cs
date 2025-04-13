using System.Diagnostics.Metrics;

int yield = int.Parse(Console.ReadLine());
int daysCount = 0;
double totalSpice = 0;

while (yield >= 100)
{
    daysCount++;
    totalSpice += yield - 26;
    yield -= 10;

}

if (daysCount > 0)
{
    totalSpice -= 26;
}
Console.WriteLine(daysCount);
Console.WriteLine(totalSpice);

