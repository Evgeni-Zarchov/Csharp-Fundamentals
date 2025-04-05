int hours = int.Parse(Console.ReadLine());
int currentMinutes = int.Parse(Console.ReadLine());

int minutes = currentMinutes + 30;

if (minutes >= 59)
{
    hours++;
    minutes -= 60;

    if (hours > 23)
    {
        hours = 0;
    }
}

Console.WriteLine($"{hours}:{minutes:d2}");
