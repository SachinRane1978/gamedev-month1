// Day 3 - decisions
int secret = 3;

Console.Write("Guess the number between 1 to 10 : ");

String input = Console.ReadLine();

if(int.TryParse(input, out int guess))
{
    if(guess < 1 || guess > 10 )
    {
        Console.WriteLine("Pick number between 1 to 10");
    }
    else if(guess == secret)
    {
        Console.WriteLine("Correct! You Win");
    }
    else if(guess > secret)
    {
        Console.WriteLine("Too high input");
    }
    else 
    {
        Console.WriteLine("Too low input");
    }
}

else
{
    Console.WriteLine("That's not a number");
}    

