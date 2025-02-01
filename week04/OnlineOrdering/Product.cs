using System;
using System.Collections.Generic;


public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public int ProductID {get; set; }


    public Product(string name, double price, int quantity, int productId)
    {
        ProductID = productId;
        Name = name;
        Price = price;
        Quantity = quantity;
   
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}
