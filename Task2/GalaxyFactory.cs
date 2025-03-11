public class GalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Galaxy");
        public IDevice CreateNetbook() => new Netbook("Galaxy");
        public IDevice CreateSmartphone() => new Smartphone("Galaxy");
        public IDevice CreateEBook() => new EBook("Galaxy");
    }