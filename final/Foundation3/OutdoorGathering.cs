class OutdoorGathering : Event
{
    protected string _weatherForcast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string WeatherForcast) : base (title, description, date, time, address)
    {

    }

    public string DisplayExtraDetails()
    {
        return "";
    }

    public string DisplayShortDescription()
    {
        return "";
    }

}