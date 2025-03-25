using DesignPatterns.Mediator;

namespace ICMediator
{
    public interface IMediator
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeOff(Aircraft aircraft);
    }
}