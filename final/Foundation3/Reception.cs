class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string weatherForcast) : base (title, description, date, time, address)
    {

    }

    string DisplayExtraDetails()
    {
        return "";
    }
    public string DisplayShortDescription()
    {
        return "";
    }
}