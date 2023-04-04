using System;

class Swimming : Activity
{
    // Attributes
    private float _lapNum;

    // Constructors
    public Swimming(float lapN, string date, int length) : base(date, length)
    {
        _lapNum = lapN;
        _activityType = "Swimming";
    }

    // Methods
    public override double GetDistance()
    {
        double distance = _lapNum * 50 / 1000;
        return distance;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
}