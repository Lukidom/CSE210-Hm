class Reception : Event
{
    public Reception(string title, string description, string date, string time, Address address, string weatherForcast) : base (title, description, date, time, address)
    {

    }


    public string DisplayShortDescription()
    {
        return "wedding of smith and angela";
    }
}