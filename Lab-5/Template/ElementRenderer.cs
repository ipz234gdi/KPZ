using System.Linq;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Template
{
    public abstract class ElementRenderer
    {
        public string Render(LightElementNode node)
        {
            OnBeforeRender(node);
            var start    = RenderStart(node);
            var children = RenderChildren(node);
            var end      = RenderEnd(node);
            OnAfterRender(node);
            return start + children + end;
        }

        protected virtual void OnBeforeRender(LightElementNode node) { }
        protected abstract string RenderStart(LightElementNode node);
        protected virtual string RenderChildren(LightElementNode node)
            => string.Concat(node.Children.Select(c => c.OuterHTML()));
        protected abstract string RenderEnd(LightElementNode node);
        protected virtual void OnAfterRender(LightElementNode node) { }
    }
}
