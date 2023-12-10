class Cycling : Activity
{
        protected double _speed;

    public Cycling(string date, int length, double speed) : base (date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * _lengthInMinutes;
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