using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //        Console.Write("What is the magic number?");
        //      string magicnumber = Console.ReadLine();

        //  Console.WriteLine("What is your guess?");
        // string guess = Console.ReadLine();

        Random randomGenerator = new Random();
        int magicnumber2 = randomGenerator.Next(1, 101);

        //    int magicnumber2 = int.Parse(magicnumber);
        int guess2 = 69420;

        while (guess2 != magicnumber2)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guess2 = int.Parse(guess);

            if (guess2 > magicnumber2)
            {
                Console.WriteLine("Lower");
            }
            else if (guess2 < magicnumber2)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
