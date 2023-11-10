using System
public class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        // defaults to 1/1
        _top = 1;
        _bot = 1;

    }

    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bot = 1;

    }

    public Fraction(int Top, int Bottom)
    {
        _top = Top;
        _bot = Bottom;
    }


    public string GetFractionString()
    {
        return "";
    }


}
