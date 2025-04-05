int lostGameCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

double headSetCount = lostGameCount / 2;
double mouseCount = lostGameCount / 3;
double keyboardCount = lostGameCount / 6;
double displayCount = lostGameCount / 12;

double totalExpenses = headSetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
