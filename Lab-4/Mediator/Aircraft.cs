using ICMediator;

namespace DesignPatterns.Mediator
{
  public class Aircraft
  {
    public string Name;
    // public Runway? CurrentRunway { get; set; }
    public bool IsTakingOff { get; set; }
    private IMediator mediator;

    public Aircraft(string name, int size, IMediator mediator)
    {
      this.Name = name;
      this.mediator = mediator;
    }
    public void RequestLanding()
    {
        Console.WriteLine($"Aircraft {Name} requests landing.");
        mediator.RequestLanding(this);
    }

    public void RequestTakeOff()
    {
        Console.WriteLine($"Aircraft {Name} requests take-off.");
        IsTakingOff = true;
        mediator.RequestTakeOff(this);
        IsTakingOff = false;
    }
  }
}