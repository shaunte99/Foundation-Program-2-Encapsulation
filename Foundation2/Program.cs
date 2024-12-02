using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a customer and an address
        Address address = new Address("123 Elm St", "SomeCity", "SomeState", "USA");
        Customer customer = new Customer("John Doe", address);

        // Creating products
        Product product1 = new Product("Product1", "P001", 10.99m, 2);
        Product product2 = new Product("Product2", "P002", 15.49m, 1);

        // Creating an order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Displaying packing and shipping labels and the total price
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}");
    }
}
