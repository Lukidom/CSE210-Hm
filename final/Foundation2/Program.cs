using System;

class Program
{
    static void Main(string[] args)
    {
        Products _products = new Products("test", 1, 20, 3);
        double _firstProduct = _products.CalculatePrice();

        Address _address = new Address("teststreet","testcity", "teststateorprovince", "USA");

        Customer customer = new Customer("luke", _address);
        
        Order order = new Order(customer);

        
        

    }
}