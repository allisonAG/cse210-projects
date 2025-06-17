public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, string name, int length, int laps) : base(date, name, length)
    {
        _laps = laps;
    }

     public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}