int countOfPeople = int.Parse(Console.ReadLine());
string typeOfTheGroup = Console.ReadLine();
string day = Console.ReadLine();
double price = 0;

if (day == "Friday")
{
    if (typeOfTheGroup == "Students")
    {
        price = 8.45;
    }
    else if (typeOfTheGroup == "Business")
    {
        price = 10.90;
    }
    else if (typeOfTheGroup == "Regular")
    {
        price = 15;
    }
}
else if (day == "Saturday")
{
    if (typeOfTheGroup == "Students")
    {
        price = 9.80;
    }
    else if (typeOfTheGroup == "Business")
    {
        price = 15.60;
    }
    else if (typeOfTheGroup == "Regular")
    {
        price = 20;
    }
}
else if (day == "Sunday")
{
    if (typeOfTheGroup == "Students")
    {
        price = 10.46;
    }
    else if (typeOfTheGroup == "Business")
    {
        price = 16;
    }
    else if (typeOfTheGroup == "Regular")
    {
        price = 22.50;
    }
}

double totalPrice = price * countOfPeople;

if (countOfPeople >= 30 && typeOfTheGroup == "Students")
{
    totalPrice *= 0.85;
}
else if (countOfPeople >= 100 && typeOfTheGroup == "Business")
{
    totalPrice -= totalPrice / countOfPeople * 10;
}
else if (countOfPeople >= 10 && countOfPeople <= 20 && typeOfTheGroup == "Regular")
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:f2}");
