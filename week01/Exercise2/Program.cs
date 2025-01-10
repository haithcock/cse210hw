using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();



        double 数 = double.Parse(valueFromUser);
        string 字母 = "";

        if (数 >= 90 && 数 <= 100)
        {
            字母 = "A";
        }
        else if (数 >= 80 && 数 <= 89.9999999999999999999)
        {
            字母 = "B";
        }
        else if (数 >= 70 && 数 <= 79.999999999999999999999)
        {
            字母 = "C";
        }
        else if (数 >= 60 && 数 <= 69.99999999999999999999)
        {
            字母 = "D";
        }
        else if (数 >= 0 && 数 <= 59.9999999999999999999999999)
        {
            字母 = "F";
        }
        else
        {
            Console.WriteLine("Invalid Grade.");
            return;
        }
        if (数 >= 70)
        {
            Console.WriteLine($"Congragulations you passed the class! with a {字母}");
        }
        else
        {
            Console.WriteLine($"You did not pass. You failed with a {字母} TRY HARDER NEXT TIME!");
        }
    }
}