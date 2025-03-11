public class Laptop : IDevice
    {
        private readonly string _brand;

        public Laptop(string brand)
        {
            _brand = brand;
        }

        public string GetName()
        {
            return $"{_brand} Laptop";
        }
    }