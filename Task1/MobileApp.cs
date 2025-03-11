public class MobileApp : SubscriptionCreator
{
    public override Subscription CreateSubscription(string type)
    {
        Console.WriteLine("Оформлення через мобільний додаток з бонусами...");
        var subscription = SubscriptionManager.Create(type);
        subscription.Features.Add("Мобільний бонус");
        return subscription;
    }
}

