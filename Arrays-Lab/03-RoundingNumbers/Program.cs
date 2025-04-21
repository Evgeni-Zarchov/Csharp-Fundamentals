//Read an array of real numbers (space separated), round them in "away from 0" style and print the output as in the examples:

string[] numbersAsString = Console.ReadLine().Split(" ");
double[] numbers = new double[numbersAsString.Length];

for (int i = 0; i < numbers.Length; i++)
{
    // Reading the numbers.

    double currentNumbers = double.Parse(numbersAsString[i]);

    // Save the numbers in the collection.
    numbers[i] = currentNumbers;
}

foreach (var number in numbers)
{
    Console.WriteLine($"{number} => {(int)Math.Round(number, MidpointRounding.AwayFromZero)}");
}

