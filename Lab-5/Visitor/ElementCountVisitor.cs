using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Visitor
{
    public class ElementCountVisitor : ILightNodeVisitor
    {
        public int Elements { get; private set; }
        public int Texts    { get; private set; }

        public void Visit(LightElementNode element) => Elements++;
        public void Visit(LightTextNode text)    => Texts++;
    }
}
