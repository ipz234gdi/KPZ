public class Netbook : IDevice
    {
        private readonly string _brand;

        public Netbook(string brand)
        {
            _brand = brand;
        }

        public string GetName()
        {
            return $"{_brand} Netbook";
        }
    }