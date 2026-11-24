Random rng = new Random();

int sixes = 0;

int i = 1;

int totalrolls = 600 ;

int secret = 7 ;


for (i = 1 ; i <= totalrolls ; i++)

{
    int roll = rng.Next(1,secret);

    
    Console.WriteLine($"Roll Number = {i} : {roll}");

    
    if (roll == 6)
    {
        
        sixes = sixes + 1 ;
        
    }

}    
Console.WriteLine($"Total Sixes = {sixes} out of {totalrolls}");
