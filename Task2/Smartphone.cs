public class Smartphone : IDevice
    {
        private readonly string _brand;

        public Smartphone(string brand)
        {
            _brand = brand;
        }

        public string GetName()
        {
            return $"{_brand} Smartphone";
        }
    }