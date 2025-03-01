public class Money
{
    public int Whole { get; set; }
    public int Cents { get; set; }

    public Money(int whole, int cents)
    {
        Whole = whole;
        Cents = cents;
    }

    public override string ToString() => $"{Whole}.{Cents:D2}";
}
