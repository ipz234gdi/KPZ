namespace BehavioralPatterns.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
