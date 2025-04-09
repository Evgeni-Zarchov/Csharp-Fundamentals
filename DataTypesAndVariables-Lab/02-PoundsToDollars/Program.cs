const double BritishPoundCourse = 1.31;

double dollars = double.Parse(Console.ReadLine());
double poundsConverted = dollars * BritishPoundCourse;

Console.WriteLine($"{poundsConverted:f3}");