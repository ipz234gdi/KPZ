public class WebSite : SubscriptionCreator
{
    public override Subscription CreateSubscription(string type)
    {
        Console.WriteLine("Оформлення через вебсайт...");
        return SubscriptionManager.Create(type);
    }
}

