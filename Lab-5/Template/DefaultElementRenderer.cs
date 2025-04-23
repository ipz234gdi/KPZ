using System.Linq;
using BehavioralPatterns.Composite;

namespace BehavioralPatterns.Template
{
    public class DefaultElementRenderer : ElementRenderer
    {
        protected override void OnBeforeRender(LightElementNode node)
        {
            Console.WriteLine($"[HOOK] OnBeforeRender: <{node.TagName}>");
        }

        protected override string RenderStart(LightElementNode node)
        {
            Console.WriteLine($"[STEP] RenderStart: <{node.TagName}>");
            var cls = node.CssClasses.Any() ? $" class=\"{string.Join(" ", node.CssClasses)}\"" : "";
            return $"<{node.TagName}{cls}>";
        }

        protected override string RenderChildren(LightElementNode node)
        {
            Console.WriteLine($"[STEP] RenderChildren: {node.Children.Count} child(ren)");
            return string.Concat(node.Children.Select(c => c.OuterHTML()));
        }

        protected override string RenderEnd(LightElementNode node)
        {
            Console.WriteLine($"[STEP] RenderEnd: </{node.TagName}>");
            return $"</{node.TagName}>";
        }

        protected override void OnAfterRender(LightElementNode node)
        {
            Console.WriteLine($"[HOOK] OnAfterRender: <{node.TagName}> complete");
        }
    }
}
