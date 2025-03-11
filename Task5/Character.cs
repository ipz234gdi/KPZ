public class Character
{
    public string Name { get; set; }
    public int Height { get; set; }
    public string BodyType { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothes { get; set; }
    public List<string> Inventory { get; set; } = new();
    public List<string> SpecialActions { get; set; } = new();

    public override string ToString()
    {
        return $"Ім'я: {Name}\nЗріст: {Height}\nСтатура: {BodyType}\nВолосся: {HairColor}\nОчі: {EyeColor}\nОдяг: {Clothes}\nІнвентар: {string.Join(", ", Inventory)}\nДії: {string.Join(", ", SpecialActions)}\n";
    }
}