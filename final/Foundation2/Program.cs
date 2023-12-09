using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Products _products = new Products("test", 1, 20, 3);
        List<Products> cart = new List<Products>
        {
            new Products("Apple", 1, 2.99, 3)
        };


        Customer customer = new Customer("luke", new Address("teststreet","testcity", "teststateorprovince", "USA"));

        Order order = new Order(customer);
        order.AddToProducts(cart[0]);

        
        Console.WriteLine(order.DisplayPackingLabel());
        Console.WriteLine(order.DisplayShippingLabel());
        

    }
}