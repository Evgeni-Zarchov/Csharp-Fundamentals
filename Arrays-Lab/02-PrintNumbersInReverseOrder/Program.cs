// Read n numbers and print them in reverse order, separated by a single space.

int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    // Reading the numbers.
    int currentNumbers = int.Parse(Console.ReadLine());

    // Saving the number in the array.
    numbers[i] = currentNumbers;
}

// Now to reverse a numbers, i have to use reversed for loop.

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}
