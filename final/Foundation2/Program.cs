using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Detachable duck", "DUCKAHHH32", 314, 3);
        Product product2 = new Product("Prediction Platupus", "DUCKATRON2.0", 6626, 2);
        Product product3 = new Product("Retractable Racoon", "Non-Duck-Item", 271, 1);
        Product product4 = new Product("Fast snek", "SNEKBUTFAST", 4, 2); 

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);

        Address address1 = new Address("Sandwich road", "North Gerry", "314159", "Nowhere", "Towntown");
        Address address2 = new Address("Sand-Witch path", "South Jerry", "662607015", "Somewhere", "United States"); 

        Customer customer1 = new Customer("Jerry", address1);

        Customer customer2 = new Customer("Gerry", address2);


       Order order1 = new Order(products2, customer1);
       Order order2 = new Order(products1, customer2);

       Console.WriteLine($"The packing label is {order1.GetPackingLabel()} ");
       Console.WriteLine($"The shipping label is {order1.GetShippingLabel()}");
       Console.WriteLine($"The total price of this order is {order1.GetTotalCost()}");
       Console.WriteLine("");
       Console.WriteLine("Next order");

       

       Console.WriteLine($"The packing label is {order2.GetPackingLabel()} ");
       Console.WriteLine($"The shipping label is {order2.GetShippingLabel()}");
       Console.WriteLine($"The total price of this order is {order2.GetTotalCost()}");
    }
}