class Address
{
    public string _streetAddress;

    public string _city;

    public string _stateOrProvince;

    public string _country; 

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _streetAddress = streetAddress;
    }

    // isInUsa was here but I found it unnecessary 

    public string DisplayAddress()
    {
        string address = $"{_streetAddress}{_city}{_stateOrProvince}{_country}";
        Console.WriteLine(address);
        return address;
    }
}