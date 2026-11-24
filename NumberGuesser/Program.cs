Random rng = new Random();
string playagain = "y";

while (playagain == "y")
{
    int count = 0;
    int guess = 0;
    int secret = rng.Next(1, 101);
    //Console.WriteLine($"[DEBUG] Secret is {secret}");

    
    while (guess != secret)
    {
        // ---------- NEW PART STARTS ----------
        Console.Write("Enter your guess (1-100): ");

      
        if (int.TryParse(Console.ReadLine(), out guess))      // 1. Is it a number?
        {
            if (guess < 1 || guess > 100)                     // 2. Is it in range?
            {
                Console.WriteLine("Pick a number between 1 and 100!");
            }
            else
            {
                count++;                                      // 3. Only valid guesses count

                if (guess < secret)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too High!");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Type a number.");  // Not a number at all
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
