using System;

// Create the Resume class
public class Resume
{
    // Create the member variable for the person's name
    // Create the member variable for the list of jobs
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Add a display method
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();  
        }
    }
}