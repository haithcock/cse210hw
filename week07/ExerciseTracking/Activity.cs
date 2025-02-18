using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int length)
    {
        _date = date;
        _lengthInMinutes = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

public virtual string GetSummary()
{
    return $"{_date} {GetType().Name}\n" +
           $"Duration: {_lengthInMinutes} minutes\n" +
           $"Distance: {GetDistance():F1} miles\n" +
           $"Speed: {GetSpeed():F1} mph\n" +
           $"Pace: {GetPace():F1} min per mile\n";
}

}