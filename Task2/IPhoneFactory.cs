public class IPhoneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("IPhone");
        public IDevice CreateNetbook() => new Netbook("IPhone");
        public IDevice CreateSmartphone() => new Smartphone("IPhone");
        public IDevice CreateEBook() => new EBook("IPhone");
    }