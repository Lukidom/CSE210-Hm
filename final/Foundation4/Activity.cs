using System.ComponentModel;

public class Activity
{
    protected string _activityType;

    protected string _date;

    protected int _lengthInMinutes;

    public Activity(string date, int length)
    {
        _date = date;

        _lengthInMinutes = length;
    }

    public virtual double CalculateDistance()
    {
        return 00; 
    }

    public virtual double CalculatePace()
    {
        return 00;
    }

    public virtual double CalculateSpeed()
    {
        return 00;
    }

    public string DisplaySummary()
    {
        return $"{_activityType} - {_date} - {_lengthInMinutes}";
    }

    public string GiveActivityType()
    {
        return _activityType;
    }
}   