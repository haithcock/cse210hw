using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine("What number is your guess?");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);
    }
        if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed right!");
        }
}
