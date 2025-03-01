using System;

public static class Reporting
{
    public static void IncomeInvoice(Warehouse warehouse, Product product, int quantity)
    {
        warehouse.AddProduct(product, quantity);
        Console.WriteLine($"Income Invoice: {product.Name} - {quantity} pcs");
    }
}
