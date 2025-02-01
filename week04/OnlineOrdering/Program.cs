using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create address instances for customers
        Address address1 = new Address("500-23 Changcheon-dong", "Seoul", "Seodaemun-gu", "120-836", "South Korea");
        Address address2 = new Address("574 Bryan Dr", "Apex", "NC", "27502", "United States");

        // Create customer instances
        Customer customer1 = new Customer(1, "John Doe", "john.doe@example.com", "555-1234", address1);
        Customer customer2 = new Customer(2, "Jane Smith", "jane.smith@example.com", "555-5678", address2);

        // Create product instances
        Product product1 = new Product("Apple", 0.75, 150, 101);
        Product product2 = new Product("Milk", 2.85, 50, 102);
        Product product3 = new Product("Bread", 1.50, 40, 103);
        Product product4 = new Product("Butter", 3.50, 30, 104);
        Product product5 = new Product("Cheese", 4.50, 25, 105);

        // Create order instances
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GenerateShippingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order.CalculateTotalPrice():0.00}");
        Console.WriteLine("--------------------------------------");
    }
}
