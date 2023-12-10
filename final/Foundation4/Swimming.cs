class Swimming : Activity
{

    protected double _NumberOfLaps;

    public Swimming(string date, int length, double numberOfLaps) : base (date, length)
    {
        _NumberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return _NumberOfLaps * 50 / 1000 * 0.62;
    }

    public override double CalculatePace()
    {
        return _lengthInMinutes / CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return 60 / CalculatePace();
    }

}