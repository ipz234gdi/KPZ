public class PremiumSubscription : Subscription
{
    public PremiumSubscription()
    {
        Price = 400;
        MinPeriod = 12;
        Channels = new List<string> { "Спорт", "Фільми", "Серіали", "Наука", "Документалки", "Новини" };
        Features = new List<string> { "4K якість", "Ексклюзивний контент" };
    }
}

