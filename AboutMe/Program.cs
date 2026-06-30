Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age >= 13 && age < 18)
{
    Console.WriteLine("You are a teenager.");
}
else if (age >= 18 && age < 65)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a senior.");
}

Console.WriteLine("Enter your height in meters: ");
double height = double.Parse(Console.ReadLine());

Console.WriteLine("Your name is " + name + ", you are " + age + " years old and your height is " + height + " m.");
int Year = 2026 - age;
Console.WriteLine($"You were born around the year {Year}.");
