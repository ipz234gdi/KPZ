public class ManagerCall : SubscriptionCreator
{
    public override Subscription CreateSubscription(string type)
    {
        Console.WriteLine("Оформлення через бота по телефону...");
        return SubscriptionManager.Create(type);
    }
}

