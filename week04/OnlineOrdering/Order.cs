using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }
    private const double DomesticShippingCost = 5.0;
    private const double InternationalShippingCost = 35.0;

    // Constructor
    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        Products.Add(product);
    }


    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        if (Customer.LivesInUnitedStates())
        {
            total += DomesticShippingCost;
        }
        else
        {
            total += InternationalShippingCost;
        }
        return total;
    }

    public string GeneratePackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in Products)
        {
            sb.AppendLine($"Product ID: {product.ProductID}, Name: {product.Name}");
        }
        return sb.ToString();
    }

    public string GenerateShippingLabel()
    {
        return $"Name: {Customer.Name}\nAddress:\n{Customer.Address.ToString()}";
    }
}
