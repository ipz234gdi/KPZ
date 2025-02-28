using System;
using System.Collections.Generic;

public class Warehouse
{
    private List<(Product, int)> products = new List<(Product, int)>();

    public void AddProduct(Product product, int quantity)
    {
        products.Add((product, quantity));
    }

    public void InventoryReport()
    {
        Console.WriteLine("Inventory Report:");
        foreach (var (product, quantity) in products)
        {
            Console.WriteLine($"{product.Name} - {quantity} pcs - {product.Price}");
        }
    }
}
