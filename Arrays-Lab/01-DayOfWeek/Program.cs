// Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

int numberOfDay = int.Parse(Console.ReadLine());

string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (numberOfDay >= 1 && numberOfDay <= 7)
{
    Console.WriteLine($"{daysOfTheWeek[numberOfDay - 1]}");
}
else
{
    Console.WriteLine("Invalid day!");
}