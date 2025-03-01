public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    // OCP: Метод можна розширити в підкласах
    public virtual void ReducePrice(Money amount)
    {
        int totalCents = Price.Whole * 100 + Price.Cents;
        int amountCents = amount.Whole * 100 + amount.Cents;
        
        totalCents -= amountCents;
        Price.Whole = totalCents / 100;
        Price.Cents = totalCents % 100;
    }
}
