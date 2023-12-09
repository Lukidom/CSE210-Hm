class Products
{
    protected string _name;
    protected int _id;
    protected double _price;

    protected double _quantity; 

    public Products(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;

    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }




}