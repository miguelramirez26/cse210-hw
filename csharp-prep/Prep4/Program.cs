using System;

class Program
{
    static void Main(string[] args)
    
    
    
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            string response = (Console.ReadLine());
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

    
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}