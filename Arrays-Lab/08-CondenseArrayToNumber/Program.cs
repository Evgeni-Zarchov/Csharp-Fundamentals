int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < array.Length - 1; i++)
{

    for (int j = 0; j < array.Length - 1 - i; j++)
    {
        ;
        array[j] = array[j] + array[j + 1];
    }
}

Console.WriteLine(array[0]);