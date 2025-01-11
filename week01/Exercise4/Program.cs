using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.Write("  Enter number: ");
        string numbersarejustwords = Console.ReadLine();
        int numbersarenownumbers = int.Parse(numbersarejustwords);
        List<int> usermadelist = new List<int>();
        usermadelist.Add(numbersarenownumbers);
        int sum = 0;

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
        float average = ((float)sum / usermadelist.Count);
        Console.WriteLine($"Your average is {average}");
        Console.WriteLine($"The sum of the numbers you added is {sum}");






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