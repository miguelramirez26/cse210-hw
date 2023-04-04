using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Golden Star Event Center: 456 Oak Avenue", "Los Angeles", "CA", "USA");

        Lecture lecture = new Lecture("Prince EA", 80, "Unleashing Your Inner Champion: The Power of Self-Motivation", "In this motivational talk, Prince EA will inspire and empower his audience to tap into their inner champion and unlock their full potential.", "05/03/2023", "7:00 P.M", address);
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.LectureFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();

        Console.WriteLine();
        Console.WriteLine($"---------------");
        Reception reception = new Reception("ForeverInLove@gmail.com", "Anne and Martin", "You're invited to celebrate the union and eternal marriage of Anne and Martin", "07/06/2023", "5:30 P.M", address);
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.ReceptionFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();

        Console.WriteLine();
        Console.WriteLine($"---------------");
        Outdoor outdoor = new Outdoor("70°F", "Outdoor Movie", "Join us for a magical outdoor movie! Our big screen will showcase a family-friendly movie that will delight kids and adults alike. Enjoy freshly popped popcorn, delicious snacks, and refreshing drinks as you relax in the open air with friends and family.", "04/15/2023", "6:00 P.M", address);
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.OutdoorFullDetails();
        Console.WriteLine();
        outdoor.DisplayShortDescription();
    }
}