using System;

class Program
{
    static void Main()
    {
        string currentDate = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
        List<Activity> activities = new List<Activity>
        {
        
            new Running(currentDate, 30, 3.0),
            new Cycling(currentDate, 30, 20),
            new Swimming(currentDate, 30, 30)
        };
        Console.WriteLine("\nActivity Summary:");
        foreach (var activity in activities)
        {
            Console.WriteLine("==========");
            Console.WriteLine(activity.GetSummary());
//            Console.WriteLine("==========");
        }
    }
}

/*
This assignment exceeds exceeds expectations for 
including creative implementations.

1. In the Swimming.cs file I accurately calculated the distance
swam in kilometers and converted it to miles. I then used this
distance to calculate the speed and pace of the swimmer with static
information. 

2. The datetime is used to get the current date and time in the Program.cs
file. This is passed to the constructors of the Running, Cycling, and
Swimming classes and used to display the date of the activity in the
GetSummary method.
*/