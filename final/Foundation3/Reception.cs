using System;

class Reception : Event
{
    // Attributes
    private string _emailRSVP;

    // Constructors
    public Reception(string emailRSVP, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
        _eventType = "Reception";
    }

    // Methods
    public void ReceptionFullDetails()
    {
        Console.WriteLine($"Full details:");
        Console.WriteLine($"*{_eventType}*");
        Console.WriteLine($"'{_eventTitle}'");
        Console.WriteLine($"--{_description}--");
        Console.WriteLine($"{_date} @ {_time}");
        _address.DisplayAddress();
        Console.WriteLine($"Please RSVP @{_emailRSVP}");
    }
}