public class DomesticSubscription : Subscription
{
    public DomesticSubscription()
    {
        Price = 200;
        MinPeriod = 1;
        Channels = new List<string> { "Новини", "Фільми" };
        Features = new List<string> { "HD якість", "Без реклами" };
    }
}

