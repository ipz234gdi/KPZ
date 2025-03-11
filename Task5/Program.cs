internal class Program
{
    static void Main(string[] args)
    {
        var director = new CharacterDirector();

        var heroBuilder = new HeroBuilder();
        var enemyBuilder = new EnemyBuilder();

        var hero = director.CreateHero(heroBuilder);
        var enemy = director.CreateEnemy(enemyBuilder);

        Console.WriteLine("Герой:");
        Console.WriteLine(hero);

        Console.WriteLine("Ворог:");
        Console.WriteLine(enemy);
    }
}