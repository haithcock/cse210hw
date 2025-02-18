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
        Console.WriteLine("Activity Summary:\n");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("==========");
        }
    }
}