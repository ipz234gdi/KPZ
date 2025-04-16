using System.Collections.Generic;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Visitor
{
    public class CssClassCollectorVisitor : ILightNodeVisitor
    {
        public HashSet<string> Classes { get; } = new();
        public Dictionary<string, int> ClassCounts { get; } = new();

        public void Visit(LightElementNode element)
        {
            foreach (var cls in element.CssClasses)
            {
                if (ClassCounts.ContainsKey(cls))
                    ClassCounts[cls]++;
                else
                    ClassCounts[cls] = 1;
            }
        }

        public void Visit(LightTextNode text)
        {
            // нічого не робимо
        }
    }
}
