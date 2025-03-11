public class EducationalSubscription : Subscription
{
    public EducationalSubscription()
    {
        Price = 150;
        MinPeriod = 6;
        Channels = new List<string> { "Наука", "Документалки" };
        Features = new List<string> { "HD якість", "Лекції", "Доступ до архівів" };
    }
}

