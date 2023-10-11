Console.WriteLine("Hello, Whats your name?");
string name = Console.ReadLine();
while(true)
{ 
Console.WriteLine($" {name}, Please enter a number between 1-100");

int number = int.Parse(Console.ReadLine());

int ans;




    if (number <= 60 && number % 2 == 1)
    {
        Console.WriteLine($"{number} is less than 60 and odd");


    }
    else if (number > 60 && number % 2 == 0)
    {
        Console.WriteLine($"{number} is greater than 60 and even");
    }

    else if (number >= 2 && number <= 24 && number % 2 == 0)
    {
        Console.WriteLine($"{number} is even and less than 25 ");
    }
    else if (number >= 26 && number <= 60 && number % 2 == 0)
    {
        Console.WriteLine($"{number} is even and between 26 and 60");
    }
    else if (number > 60 && number % 2 == 1)
    {
        Console.WriteLine($"{number} Is odd and greater than 60");
    }
    else { }


    Console.WriteLine("Would you like to continue? 1=yes 0=no");
    int command = Convert.ToInt32(Console.ReadLine());
    if (command == 0 ) 
    {
        Console.WriteLine($"thank you {name} for playing, have a good day!");
        break;
    }

   
    
}
 

