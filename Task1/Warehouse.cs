public class Warehouse : IReportable
{
    private List<(Product, int)> products = new List<(Product, int)>();

    public void AddProduct(Product product, int quantity)
    {
        if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
        products.Add((product, quantity));
    }

    public void GenerateReport()
    {
        Console.WriteLine("Inventory Report:");
        foreach (var (product, quantity) in products)
        {
            Console.WriteLine($"{product.Name} - {quantity} pcs - {product.Price}");
        }
    }
}
