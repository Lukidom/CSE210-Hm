class Lecture : Event
{
    protected string _speaker;

    protected int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {

    }

    public string DisplayExtraDetails()
    {
        return $"{_speaker} - {_capacity}";
    }
    public string DisplayShortDescription()
    {
        return "Learn about faith";
    }
}