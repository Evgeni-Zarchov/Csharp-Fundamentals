string typeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int priceOfTickets = 0;

if (age >= 0 && age <= 18)
{
    if (typeOfDay == "Weekday")
    {
        priceOfTickets = 12;
    }
    else if (typeOfDay == "Weekend")
    {
        priceOfTickets = 15;
    }
    else if (typeOfDay == "Holiday")
    {
        priceOfTickets = 5;
    }
}
else if (age >= 18 && age <= 64)
{
    if (typeOfDay == "Weekday")
    {
        priceOfTickets = 18;
    }
    else if (typeOfDay == "Weekend")
    {
        priceOfTickets = 20;
    }
    else if (typeOfDay == "Holiday")
    {
        priceOfTickets = 12;
    }
}
else if (age >= 64 && age <= 122)
{
    if (typeOfDay == "Weekday")
    {
        priceOfTickets = 12;
    }
    else if (typeOfDay == "Weekend")
    {
        priceOfTickets = 15;
    }
    else if (typeOfDay == "Holiday")
    {
        priceOfTickets = 10;
    }
}
else
{
    Console.WriteLine("Error!");
}

if (priceOfTickets > 0)
{
    Console.WriteLine($"{priceOfTickets}$");
}

