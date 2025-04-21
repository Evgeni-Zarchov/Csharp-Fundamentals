// Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated strings. Print the output on a single line (space separated).

string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < array.Length / 2; i++)
{
    string firstElement = array[i];
    string lastElement = array[array.Length - 1 - i];

    array[i] = lastElement;
    array[array.Length - 1 - i] = firstElement;
}
Console.WriteLine(string.Join(" ", array));