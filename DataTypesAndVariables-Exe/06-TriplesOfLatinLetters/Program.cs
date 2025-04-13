int endIndex = int.Parse(Console.ReadLine());

for (int i = 0; i < endIndex; i++)
{
    for (int j = 0; j < endIndex; j++)
    {
        for (int k = 0; k < endIndex; k++)
        {
            char firstChar = (char)('a' + i);
            char secondChar = (char)('a' + j);
            char thirdChar = (char)('a' + k);

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}
