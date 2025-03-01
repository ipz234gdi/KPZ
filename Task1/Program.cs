using System;

class Program
{
    static void Main(string[] args)
    {
        Money price = new Money(100, 50);
        Product xiaomi = new Product("xiaomi", price);
        Warehouse warehouse = new Warehouse();

        Reporting.IncomeInvoice(warehouse, xiaomi, 10);
        warehouse.GenerateReport();

        xiaomi.ReducePrice(new Money(10, 75));
        Console.WriteLine($"New price of {xiaomi.Name}: {xiaomi.Price}");
    }
}
