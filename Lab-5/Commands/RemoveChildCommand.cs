using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Commands
{
    public class RemoveChildCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _child;

        public RemoveChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute() => _parent.RemoveChild(_child);
        public void Undo() => _parent.AddChild(_child);
    }
}