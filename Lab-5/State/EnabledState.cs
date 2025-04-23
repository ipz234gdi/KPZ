using BehavioralPatterns.Composite;

namespace BehavioralPatterns.State
{
    public class EnabledState : IElementState
    {
        public void AddChild(LightElementNode element, LightNode child)
            => element.AddChildInternal(child);

        public void AddClass(LightElementNode element, string className)
            => element.AddClassInternal(className);
    }
}
