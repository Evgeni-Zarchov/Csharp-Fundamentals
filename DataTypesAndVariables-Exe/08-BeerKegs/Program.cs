int n = int.Parse(Console.ReadLine());
double theBiggerKeg = double.MinValue;
string bestKeg = "";

for (int i = 0; i < n; i++)
{
    string kegModel = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double currentKegPower = Math.PI * radius * radius * height;

    if (currentKegPower >= theBiggerKeg)
    {
        bestKeg = kegModel;
        theBiggerKeg = currentKegPower;
    }
}
Console.WriteLine(bestKeg);
