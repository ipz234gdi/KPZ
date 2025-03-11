public abstract class Subscription
{
    public decimal Price { get; protected set; }
    public int MinPeriod { get; protected set; }
    public List<string> Channels { get; protected set; }
    public List<string> Features { get; protected set; }

    public override string ToString()
    {
        return $"Ціна: {Price} грн., Мін. період: {MinPeriod} міс., \nКанали: {string.Join(", ", Channels)}, \nМожливості: {string.Join(", ", Features)}";
    }
}

