internal class Program
{
    static void Main(string[] args)
    {
        // Створення головного віруса
        var virus1 = new Virus("Covid-19", "Coronavirus", 0.0000001, 1);
        // Створення дітей віруса
        var child1 = new Virus("Delta", "Coronavirus", 0.00000009, 0);
        var child2 = new Virus("Omicron", "Coronavirus", 0.00000008, 0);

        // додавання вірусу датей
        virus1.AddChild(child1);
        virus1.AddChild(child2);

        // створення і додавання дідей дитя
        var grandChild1 = new Virus("Omicron X", "Coronavirus", 0.00000007, 0);
        child2.AddChild(grandChild1);

        // виведення сімейство вірусів
        Console.WriteLine("Оригінальний вірус:");
        Console.WriteLine(virus1);

        // Клонування
        var clonedVirus = (Virus)virus1.Clone();

        Console.WriteLine("Клонований вірус:");
        Console.WriteLine(clonedVirus);

        // Перевіримо, що об'єкти різні
        Console.WriteLine($"Це один і той самий об'єкт? {ReferenceEquals(virus1, clonedVirus)}");
        Console.WriteLine($"Діти оригіналу і клону співпадають? {ReferenceEquals(virus1.Children[0], clonedVirus.Children[0])}");
    }
}