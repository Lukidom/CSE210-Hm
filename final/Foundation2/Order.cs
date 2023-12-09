
class Order
{
    protected List<Products> orderContents = new List<Products>();

    protected Customer _customer;

    protected double _price;

    public Order(Customer customer)
    {
        this._customer = customer;
    } 

    public double CalculateTotalOrderCost()
    {
        foreach (Products product in orderContents)
        {
            _price += product.CalculatePrice();
        }
        _price += CalculateShippingCost();
        return _price;

    }

    public int CalculateShippingCost()
    {
        // temporary return
        if (_customer.FromUnitedStates())
        {
            return 5;
        }
        return 35;

    }

     public String DisplayPackingLabel()
     {
        var itemsString = "";
        foreach (Products product in orderContents)
        {
            itemsString += product.GetName() + ", " + product.GetId();
        }
        return itemsString;
     }

     public string DisplayShippingLabel()
     {
        return "Name:" + _customer.GetNameCustomer() + "\n Address" + _customer.GetAddress().DisplayAddress() + "\n";
     }

     public void AddToProducts(Products product)
    {
        orderContents.Add(product);
    }



}