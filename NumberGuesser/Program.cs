Random rng = new Random();
string playagain = "y";
SayHello("Likhit");
while (playagain == "y")
{
    int count = 0;
    int guess = 0;
    int secret = rng.Next(1, 101);
    Console.WriteLine($"[DEBUG] Secret is {secret}");

    
    while (guess != secret)
    {
        // ---------- NEW PART STARTS ----------
        //Console.Write("Enter your guess (1-100): ");

      
        guess = AskNumber(1,100);
            
        count++;                                      // 3. Only valid guesses count

        if (guess < secret)
        {
            Console.WriteLine("Too Low!");
        }
        else if (guess > secret)
        {
            Console.WriteLine("Too High!");
        }
            
        
        
        
        // ---------- NEW PART ENDS ----------
    }

    Console.WriteLine($"Correct! You got it in {count} attempts.");

    playagain = "";
    while (playagain != "y" && playagain != "n")
    {
        Console.Write("Play again (y / n): ");
        playagain = Console.ReadLine();
    }
}

Console.WriteLine("Thanks for playing!");

void SayHello(string name)
{
    Console.WriteLine($"Namaste, {name}! Welcome to Number Guesser.");
}

int AskNumber(int min, int max)
{
    while (true)
    {
        Console.Write($"Enter your guess ({min}-{max}): ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= min && number <= max)
            {
                return number;
            }
            Console.WriteLine($"Pick a number between {min} and {max}!");
        }
       
    else
        {
            Console.WriteLine("Invalid input. Type a number.");  // Not a number at all
        }
    
    }
}