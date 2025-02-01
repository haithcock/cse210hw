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
        Customer customer1 = new Customer(1, "신소라", "doodlest.bug@navercorp.com", "010-1234-8765", address1);
        Customer customer2 = new Customer(2, "Daniel Boone", "daniel.boone@gmail.com", "555-5678", address2);

        // Create product instances
        Product product1 = new Product("Detent Spring", 0.75, 20, 101);
        Product product2 = new Product("Detent", 2.85, 20, 102);
        Product product3 = new Product("20-inch Barrel", 150, 5, 103);
        Product product4 = new Product("Butter", 3.50, 2, 104);
        Product product5 = new Product("Hi-Chews", 4.50, 25, 105);

        // Create order instances
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to orders
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order2.AddProduct(product3);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

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
