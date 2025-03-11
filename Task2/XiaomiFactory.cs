public class XiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Xiaomi");
        public IDevice CreateNetbook() => new Netbook("Xiaomi");
        public IDevice CreateSmartphone() => new Smartphone("Xiaomi");
        public IDevice CreateEBook() => new EBook("Xiaomi");
    }