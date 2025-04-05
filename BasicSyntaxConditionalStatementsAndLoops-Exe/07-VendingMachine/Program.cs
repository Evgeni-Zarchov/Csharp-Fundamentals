double totalMoney = 0;
string action;
while ((action = Console.ReadLine()) != "Start")
{
    double coins = double.Parse(action);

    if (coins == 0.10 ||
        coins == 0.20 ||
        coins == 0.50 ||
        coins == 1.00 ||
        coins == 2.00)
    {
        totalMoney += coins;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coins}");
        continue;
    }
}

double price = 0;

while ((action = Console.ReadLine()) != "End")
{
    string products = action;

    switch (products)
    {
        case "Nuts":
            price = 2.00;
            break;
        case "Water":
            price = 0.70;
            break;
        case "Crisps":
            price = 1.50;
            break;
        case "Soda":
            price = 0.80;
            break;
        case "Coke":
            price = 1.00;
            break;
        default:
            Console.WriteLine("Invalid product");
            continue;
    }

    if (totalMoney >= price)
    {
        Console.WriteLine($"Purchased {products.ToLower()}");
        totalMoney -= price;
    }
    else
    {
        Console.WriteLine("Sorry, not enough money");
    }

}

Console.WriteLine($"Change: {totalMoney:f2}");