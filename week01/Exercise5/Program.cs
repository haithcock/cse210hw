using System;

class Program
{
    static string username;
    static double favoritenumber;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        UserFavoriteNumber();

        int squaredNumber = SquareNumber((int)favoritenumber);
        DisplayResult(username, squaredNumber);
        last();

    }
    static void DisplayMessage()
    {
        Console.WriteLine("What is your name?");
        username = Console.ReadLine();
        Console.WriteLine($"Hello, {username}");
    }
    static void UserFavoriteNumber()
    {
        Console.WriteLine("What is your favorite Number?");
        string input = Console.ReadLine();

        if (double.TryParse(input, out favoritenumber))
        {
            Console.WriteLine($"Your favorite number is {favoritenumber}");
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a valid number with digits and/or decimals.");
        }
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your squared favorite number is {squaredNumber}");
    }
    static void last()
    {
        Console.WriteLine($"Your name is {username} and your favorite number is {favoritenumber}");
    }
}