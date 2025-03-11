internal class Program
{
    static void Main(string[] args)
    {
        var auth1 = Authenticator.Instance;
        var auth2 = Authenticator.Instance;

        // Тест однаковості об'єктів
        Console.WriteLine($"auth1 і auth2 — це один і той самий об'єкт: {ReferenceEquals(auth1, auth2)}");

        auth1.Authenticate("Denys", "42_42_42");
        auth2.Authenticate("Alysa", "3301228");

        Console.WriteLine("Аутентифікація завершена.");
    }
}