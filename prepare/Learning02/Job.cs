using System;

// Create the Job class
public class Job
{
    // Create member variables in the class for each element 
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Add a display method 
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}