class Lecture : Event
{
    protected string _speaker;

    protected int Capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
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