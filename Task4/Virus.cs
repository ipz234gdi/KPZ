public class Virus : IVirusPrototype
{
    public string Name { get; set; } // імя 
    public string Species { get; set; } // вид
    public double Weight { get; set; } // вага
    public int Age { get; set; } // рік
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
    }

    // Додавання дітей
    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    // клонування
    public IVirusPrototype Clone()
    {
        // Глибоке клонування
        var clonedVirus = new Virus(Name, Species, Weight, Age);

        foreach (var child in Children)
        {
            clonedVirus.AddChild((Virus)child.Clone());
        }

        return clonedVirus;
    }

    // виведення регільтатів
    public override string ToString()
    {
        string result = $"Вірус: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}";

        if (Children.Any())
        {
            result += "\n  Діти:";
            foreach (var child in Children)
            {
                result += "\n    " + child.ToString().Replace("\n", "\n    ");
            }
        }

        return result;
    }

}