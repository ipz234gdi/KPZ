namespace DesignPatterns.Mediator
{
  public class Runway
  {
    public readonly Guid Id = Guid.NewGuid();
    public Aircraft? OccupiedBy { get; private set; }
    public bool IsFree => OccupiedBy == null;

    public void Occupy(Aircraft aircraft)
    {
        OccupiedBy = aircraft;
        Console.WriteLine($"Runway {Id} is now occupied by {aircraft.Name}.");
        HighLightRed();
    }

    public void Vacate()
    {
        Console.WriteLine($"Runway {Id} is now free.");
        OccupiedBy = null;
        HighLightGreen();
    }

    public void HighLightRed() => Console.WriteLine($"Runway {Id} is busy!");
    public void HighLightGreen() => Console.WriteLine($"Runway {Id} is free!");
  }
}