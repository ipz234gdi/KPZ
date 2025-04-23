using BehavioralPatterns.Composite;

namespace BehavioralPatterns.State
{
    public interface IElementState
    {
        void AddChild(LightElementNode element, LightNode child);
        void AddClass(LightElementNode element, string className);
    }
}
