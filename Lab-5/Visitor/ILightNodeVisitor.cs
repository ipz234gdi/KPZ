using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Visitor
{
    public interface ILightNodeVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode text);
    }
}
