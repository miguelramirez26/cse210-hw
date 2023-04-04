using System;

class Outdoor : Event
{
    // Attributes
    private string _weather;

    // Constructors
    public Outdoor(string weather, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }

    // Methods
    public void OutdoorFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"--{_description}--");
        Console.WriteLine($"{_weather}");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
    }
}