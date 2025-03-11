public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateSmartphone();
        IDevice CreateEBook();
    }