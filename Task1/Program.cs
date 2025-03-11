internal class Program
{
    static void Main(string[] args)
    {
        var creators = new List<SubscriptionCreator>
            {
                new WebSite(),
                new MobileApp(),
                new ManagerCall()
            };

        for (int i = 0; i < creators.Count; i++)
        {
            var creator = creators[i];
            Subscription subscription = null;

            if (i == 0) { subscription = creator.CreateSubscription("Premium"); }
            else if (i == 1) { subscription = creator.CreateSubscription("Educational"); }
            else if (i == 2) { subscription = creator.CreateSubscription("Domestic"); }

            Console.WriteLine(subscription);
            Console.WriteLine();
        }
    }
}

