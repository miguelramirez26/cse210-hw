using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(8, "01 Nov 2022", 25);
        Cycling cycling = new Cycling(22.5, "02 Nov 2022", 35);
        Swimming swimming = new Swimming(20, "03 Nov 2022", 30);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}