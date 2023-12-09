using Foundation2.Product;

class Order
{
    List<Product> products = new List<Product>();

    Customer 

    protected double _price;

    public Order(Customer customer)
    {
        
    }

    public double CalculateTotalOrderCost()
    {
        // temporary return
        return 12;
    }

    public int CalculateShippingCost()
    {
        // temporary return
        return 0;

    }

     public String DisplayPackingLabel()
     {
        return _price.name;
     }

     public string DisplayShippingLabel()
     {
        return "";
     }

     public void AddToProducts()
    {

    }



}