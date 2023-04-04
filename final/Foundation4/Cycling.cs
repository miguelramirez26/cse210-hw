using System;

class Cycling : Activity
{
    // Attributes
    private double _speed;

    // Constructors
    public Cycling(double speed, string date, int length) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }

    // Methods
    public override double GetDistance()
    {
        return _length / GetPace();
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
    
    public override double GetSpeed()
    {
        return _speed;
    }
}