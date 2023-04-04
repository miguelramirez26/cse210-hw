using System;

class Event
{
    // Attributes
    public Address _address;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _eventType;

    // Constructors
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "";
    }

    // Methods
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Standard details:");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"--{_description}--");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
    }

    public string DisplayFullDetails()
    {
        return "";
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Short description:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"{_date}");
    }
}