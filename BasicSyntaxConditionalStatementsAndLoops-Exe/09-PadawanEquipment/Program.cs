double budged = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double priceForLightsabers = double.Parse(Console.ReadLine());
double priceOfRobes = double.Parse(Console.ReadLine());
double priceOfBelts = double.Parse(Console.ReadLine());

double countOfSabers = Math.Ceiling(studentsCount * 1.10);
double totalSabersPrice = countOfSabers * priceForLightsabers;
double totalRobesPrice = studentsCount * priceOfRobes;

double numberOfFreeBelts = 0;
double totalPriceForBelts = 0;

if (studentsCount >= 6)
{
    numberOfFreeBelts = Math.Floor((double)studentsCount / 6);
    totalPriceForBelts = (studentsCount - numberOfFreeBelts) * priceOfBelts;
}
else
{
    totalPriceForBelts = studentsCount * priceOfBelts;
}

double totalPrice = totalSabersPrice + totalRobesPrice + totalPriceForBelts;
double finalPrice = Math.Abs(budged - totalPrice);

if (budged >= totalPrice)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {finalPrice:f2}lv more.");
}

