using System;

class Program
{
    static void Main(string[] args)
    {
        Money price = new Money(100, 50);
        Product laptop = new Product("Laptop", price);
        Warehouse warehouse = new Warehouse();

        Reporting.IncomeInvoice(warehouse, laptop, 10);
        warehouse.InventoryReport();

        laptop.ReducePrice(new Money(10, 75));
        Console.WriteLine($"New price of {laptop.Name}: {laptop.Price}");
    }
}
