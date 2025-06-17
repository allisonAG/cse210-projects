public abstract class Activity
{
    private string _date;
    private string _name;
    private int _length;

    public Activity(string date, string name, int length)
    {
        _date = date;
        _name = name;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} per km";
    }
    
}