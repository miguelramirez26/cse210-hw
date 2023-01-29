using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        int userResponse = 0;
        while (userResponse != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                _journal.AddEntry();
            }

            else if (userResponse == 2)
            {
                _journal.Display();
            }

            else if (userResponse == 3)
            {
                _journal.Load();
            }

            else if (userResponse == 4)
            {
                _journal.Save();
            }
        }
    }
}