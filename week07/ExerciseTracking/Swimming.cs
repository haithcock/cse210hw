public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double km = _laps * 50 / 1000.0;
        return km * 0.62;
    }

    public override double GetSpeed() => (GetDistance() / Length) * 60;
    public override double GetPace() => Length / GetDistance();
}