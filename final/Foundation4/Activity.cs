class Activity
{
    protected string _activityType;

    protected string _date;

    protected int _lengthInMinutes;

    public Activity(string date, int length)
    {

    }

    abstract double CalculateDistance()
    {
        return 00;
    }

    abstract double CalculateSpace()
    {
        return 00;
    }

    abstract double CalculateSpeed()
    {
        return 00;
    }

    public string DisplaySummary()
    {
        return "";
    }

    public string GiveActivityType()
    {
        return "";
    }
}   