class Running : Activity
{
    protected double _distance;

    public Running(string date, int length, double distance) : base (date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculatePace()
    {
        return _lengthInMinutes / _distance;
    }

    public override double CalculateSpeed()
    {
        return 60 / CalculatePace();
    }
}