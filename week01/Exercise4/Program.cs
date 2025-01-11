using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int sum = 0;
        Console.Write("  Enter a number (Press 0 to quit and compute your sum, average, and ): ");
        string numbersarejustwords = Console.ReadLine();
        int numbersarenownumbers = int.Parse(numbersarejustwords);
        sum += numbersarenownumbers;
        List<int> usermadelist = new List<int>();
        usermadelist.Add(numbersarenownumbers);

    
        while (numbersarenownumbers != 0)
        {
            Console.WriteLine("Enter a number");

            numbersarejustwords = Console.ReadLine();
            numbersarenownumbers = int.Parse(numbersarejustwords);

            if (numbersarenownumbers == 0)
            {

            }
            else
            {

                usermadelist.Add(numbersarenownumbers);


            }
            sum += numbersarenownumbers;

        }

        int highestnumber = usermadelist.Max();
        int lowestnumber = usermadelist.Min();
        
        foreach (int number in usermadelist)
        {
            if (number > highestnumber)
            {
                highestnumber = number;
            }
            if (number < lowestnumber)
            {
                lowestnumber = number;
            }
        }

        float average = ((float)sum / usermadelist.Count);
        Console.WriteLine($"Your average is {average}");
        Console.WriteLine($"The sum of the numbers you added is {sum}");
        Console.WriteLine($"Your highest number is {highestnumber}:);
        Console.WriteLine($"Your lowest number is {lowerstnumber}");






        //        while (guess != 0);
        //   List<string> shins = new List<string>();
        //   shins.Add("Seongyong");
        //   shins.Add("Laurie");
        //  Console.WriteLine(shins.Count);
        //   Console.WriteLine($"Once upon a time there were {shins.Count} people");

        //        foreach (string familymembow in shins)
        //        {
        //            Console.WriteLine(familymembow);
        //       }
        //
        //       shins.Add("Adam");
        //       shins.Add("Emma");
        //       shins.Add("Caleb");
        //       shins.Add("Jared");
        //       shins.Add("Laura");
        //
        //        Console.WriteLine($"But then they got busy and soon their family became a family of {shins.Count}.");
        //
        //        foreach (string familymembow in shins)
        //        {
        //            if (familymembow == "Emma")
        //            {
        //               Console.WriteLine($"{familymembow} was nice this year.");
        //            }

        //            else
        //            {
        //               Console.WriteLine($"{familymembow} was naughty this year.");
        //           }
        //
        //      }

    }
}