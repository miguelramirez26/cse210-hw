using System;

class Activity
{
    // Attributes
    protected string _date;
    protected int _length; 
    protected string _activityType;

    // Constructors
    public Activity(string date, int minute)
    {
        _date = date;
        _length = minute;
    }

    // Methods
    public virtual double GetDistance()
    {
        return 1;
    }

    public virtual double GetSpeed()
    {
        return 1;
    }

    public virtual double GetPace()
    {
        return 1;
    }

    public void GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {distance.ToString("F2")} km, Speed {speed.ToString("F2")} kph, Pace: {pace.ToString("F2")} min per km");
    }
}