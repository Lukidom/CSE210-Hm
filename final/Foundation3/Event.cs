using System.Net.Sockets;

class Event
{
    protected string _title;

    protected string _description;

    protected string _date;
    
    protected string _time;

    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string DisplayStandardDetails()
    {
        return $"{_title} - {_description} - {_date} - {_time} - {_address.DisplayAddress()}";
    }
    
}