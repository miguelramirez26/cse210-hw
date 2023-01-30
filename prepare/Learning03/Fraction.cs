using System;

// Step 3: Create the Fraction class
public class Fraction
{
    private int _top;
    private int _bottom;

    // Step 4: Create the Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 5: Create the Getters and Setters
    // public int GetTop()
    // {
    //     return _top;
    // }

    // public int GetBottom()
    // {
    //     return _bottom;
    // }

    // public void SetTop(int top)
    // {
    //     _top = top;
    // }

    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }

    // Step 6: Create methods to return the representations
    public string GetFractionString()
    {
        return Convert.ToString(_top) + "/" + Convert.ToString(_bottom);
    }

    public double GetDecimalValue()
    {
        return Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
    }
}