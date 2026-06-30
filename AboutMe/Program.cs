Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in meters: ");
double height = double.Parse(Console.ReadLine());

Console.WriteLine("Your name is " + name + ", you are " + age + " years old and your height is " + height + " m.");
const int currentYear = 2026;
Console.WriteLine($"You were born around the year { currentYear - age}.");

