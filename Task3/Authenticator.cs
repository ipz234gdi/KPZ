public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance = new Lazy<Authenticator>(() => new Authenticator());
        
        // Приватний конструктор, щоб не дозволити створювати екземпляри ззовні
        private Authenticator()
        {
            Console.WriteLine("Створено екземпляр Authenticator");
        }

        // Публічний доступ до єдиного екземпляру
        public static Authenticator Instance => _instance.Value;

        // Приклад методу
        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Користувач {username} аутентифікований (умовно)");
        }
    }