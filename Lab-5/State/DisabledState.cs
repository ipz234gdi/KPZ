using System;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.State
{
    public class DisabledState : IElementState
    {
        public void AddChild(LightElementNode element, LightNode child)
            => throw new InvalidOperationException("Element is disabled");

        public void AddClass(LightElementNode element, string className)
            => throw new InvalidOperationException("Element is disabled");
    }
}
