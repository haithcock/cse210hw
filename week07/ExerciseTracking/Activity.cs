using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public int Length => _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

public virtual string GetSummary()
{
    return $"{_date} {GetType().Name}\n" +
           $"Duration: {_length} minutes\n" +
           $"Distance: {GetDistance():F1} miles\n" +
           $"Speed: {GetSpeed():F1} mph\n" +
           $"Pace: {GetPace():F1} min per mile\n";
}

}