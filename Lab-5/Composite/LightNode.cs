using BehavioralPatterns.Visitor;

namespace BehavioralPatterns
{
    public abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();

        public abstract void Accept(ILightNodeVisitor visitor);

    }
}