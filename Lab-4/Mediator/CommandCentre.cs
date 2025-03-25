using ICMediator;

namespace DesignPatterns.Mediator
{
    public class CommandCentre : IMediator
    {
        private List<Runway> runways = new();
        private List<Aircraft> aircrafts = new();

        public CommandCentre(Runway[] runways)
        {
            this.runways.AddRange(runways);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Runway? freeRunway = runways.FirstOrDefault(r => r.IsFree);
            if (freeRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {freeRunway.Id}.");
                freeRunway.Occupy(aircraft);
            }
            else
            {
                Console.WriteLine($"No available runway for aircraft {aircraft.Name}. Waiting...");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Runway? occupiedRunway = runways.FirstOrDefault(r => r.OccupiedBy == aircraft);
            if (occupiedRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {occupiedRunway.Id}.");
                occupiedRunway.Vacate();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}