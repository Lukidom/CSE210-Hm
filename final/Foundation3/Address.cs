class Address
{
    protected string _streetAddress;

    protected string _city;

    protected string _state;

    protected string _zipcode;

    public Address(string streetaddress, string city, string state, string zipcode)
    {
        _streetAddress = streetaddress;
        _city = city;
        _state = state;
        _zipcode = zipcode;

    }

    public string DisplayAddress()
    {
        return $"{_streetAddress} - {_city} - {_state} - {_zipcode}";
    }

}