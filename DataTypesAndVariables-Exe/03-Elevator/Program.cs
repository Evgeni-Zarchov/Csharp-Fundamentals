int numberOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

double numberOfCourse = (int)Math.Ceiling((double)numberOfPeople / capacity);
Console.WriteLine(numberOfCourse);
