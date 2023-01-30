using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4: 
        Fraction f = new Fraction();

        Fraction f1 = new Fraction(5);

        Fraction f2 = new Fraction(3, 4);

        Fraction f3 = new Fraction(1, 3);

        //  Step 5: Create the Getters and Setters
        // f.SetTop(1);
        // f.SetBottom(2);

        // f1.SetTop(3);
        // f1.SetBottom(4);

        // f2.SetTop(5);
        // f2.SetBottom(6);

        // f3.SetTop(7);
        // f3.SetBottom(8);

        // Console.WriteLine(f.GetTop() + "/" + f.GetBottom());
        // Console.WriteLine(f1.GetTop() + "/" + f1.GetBottom());
        // Console.WriteLine(f2.GetTop() + "/" + f2.GetBottom());
        // Console.WriteLine(f3.GetTop() + "/" + f3.GetBottom()); 


        // Step 6: Create methods to retun the representations
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());

        Console.WriteLine(f.GetDecimalValue());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());

    }
}