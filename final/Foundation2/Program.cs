using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create customers
        Customer customer1 = new Customer("John Smith", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Jane Doe", new Address("456 Elm St", "Los Angeles", "CA", "USA"));

        // Create products
        Product product1 = new Product("Product 1", "P1", 10.99, 2);
        Product product2 = new Product("Product 2", "P2", 19.99, 1);
        Product product3 = new Product("Product 3", "P3", 5.99, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}