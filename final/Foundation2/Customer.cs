class Customer
{
    protected string _name;

    protected Address _customerAddress;

    protected bool isInUSA = false;

    public Customer(string name, Address address)
    {
        _name = name;
        _customerAddress = address;
        isInUSA = FromUnitedStates();

    }

    public bool FromUnitedStates()
    {   
        if (_customerAddress._country == "USA")
        {
            return true;
        }
        return false;

    }
}