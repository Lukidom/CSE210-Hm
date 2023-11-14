using System;
using System.Globalization;
public class Fraction
{
    // Create a class to hold fraction.
    // The class should be in its own file.
    // The class should have two attributes for the top and bottom numbers.
    // Make sure the attributes are private.
    public int number;
    private int _top;
    private int _bottom;

    // Create the following constructors:
    // Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }
    
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetFractionDecimal()
    {
        return (double)_top / _bottom;
    }
    
    // Create getters and setters for both the top and the bottom values.
    
    // public int Get_top()
    // {
    //     return _top;
    // }

    // public int Get_bottom()
    // {
    //     return int _bottom;
    // }
}
