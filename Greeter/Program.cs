// Day 2 - asking the player
Console.Write("What is your name? = ");
string name = Console.ReadLine();

Console.Write("What is your age? = ");
int age = int.Parse(Console.ReadLine());

Console.Write("What is your favorite game? = ");
string game = Console.ReadLine();

Console.Write("How many hours do you play game in a day? = ");
double hours = double.Parse(Console.ReadLine());

Console.WriteLine($"Namaste, {name}! You love {game}.");
Console.WriteLine($"You play {hours*7} hours a week");
Console.WriteLine($"In 10 years you will be {age+10} and still gaming!");