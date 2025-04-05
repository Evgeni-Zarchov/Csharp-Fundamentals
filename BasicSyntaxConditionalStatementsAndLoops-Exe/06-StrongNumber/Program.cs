int number = int.Parse(Console.ReadLine());
int sum = 0;

int currentNumber = number;
while (currentNumber != 0)
{
    int digit = currentNumber % 10;
    currentNumber /= 10;
    int factorial = 1;

    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }

    sum += factorial;
}

if (sum != number)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("yes");
}

