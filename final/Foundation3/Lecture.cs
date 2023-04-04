using System;

class Lecture : Event
{
    // Attributes
    private string _speakerName;
    private int _capacity;

    // Constructors
    public Lecture(string speakerName, int capacity, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    // Methods
    public void LectureFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"--{_description}--");
        Console.WriteLine($"Available seats: {_capacity}");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
    }
}