public class EBook : IDevice
    {
        private readonly string _brand;

        public EBook(string brand)
        {
            _brand = brand;
        }

        public string GetName()
        {
            return $"{_brand} E-Book";
        }
    }