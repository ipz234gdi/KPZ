internal class Program
{
    static void Main(string[] args)
    {
        var factories = new List<IDeviceFactory>
            {
                new IPhoneFactory(),
                new XiaomiFactory(),
                new GalaxyFactory()
            };

        foreach (var factory in factories)
        {
            var laptop = factory.CreateLaptop();
            var netbook = factory.CreateNetbook();
            var smartphone = factory.CreateSmartphone();
            var ebook = factory.CreateEBook();

            Console.WriteLine(laptop.GetName());
            Console.WriteLine(netbook.GetName());
            Console.WriteLine(smartphone.GetName());
            Console.WriteLine(ebook.GetName());
            Console.WriteLine(new string('-', 40));
        }
    }
}