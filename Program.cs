Console.WriteLine("*******************************************************************");
Console.WriteLine("Welcome to Number Analyzer! Please enter your name to continue.");
string userName = Console.ReadLine();
Console.WriteLine("*******************************************************************\n");
do
{
    //Take input from user and convert to integer value
    Console.WriteLine($"\n{userName} enter an integer between 1 to 100(inclusive).");
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    //Check if input is in range
    if (inputNumber < 1 || inputNumber > 100)
    {
        Console.WriteLine("Number is out of range!");
    }
    else
    {
        if (inputNumber % 2 == 0) // even inputNumber loop
        {
            if (inputNumber >= 2 && inputNumber <= 24) // Covers 2b of problem statement
            {
                Console.WriteLine("Even and less than 25");
            }
            else if (inputNumber >= 26 && inputNumber <= 60)  // Covers 2c of problem statement
            {
                Console.WriteLine("Even and between 26 and 60 inclusive.");
            }
            else   // Covers 2d of problem statement
            {
                Console.WriteLine("Even and greater than 60");
            }

        }
        else // odd inputNumber loop
        {
            if (inputNumber < 60)  // Covera 2a of problem statement
            {
                Console.WriteLine("Odd and less than 60.");
            }
            else // Covers 2e of problem statement
            {
                Console.WriteLine("Odd and greater than 60");
            }
        }
    }

    Console.WriteLine($"\nWould you like to continue {userName} (y/n)");

} while (Console.ReadLine() == "y");

Console.WriteLine("\n*******************************************************************");
Console.WriteLine($"Goodbye {userName}");
Console.WriteLine("\n*******************************************************************");
Console.ReadKey();