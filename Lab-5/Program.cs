using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;
using BehavioralPatterns.Iterators;
using BehavioralPatterns.State;
using BehavioralPatterns.Template;
using BehavioralPatterns.Visitor;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
root.AddChild(para);

// 1) Depth‑first
var df = root.CreateDepthFirstIterator();
Console.WriteLine("Depth‑first traversal:");
while (df.HasNext())
    Console.WriteLine("  " + df.Next().GetType().Name);

Console.WriteLine();

// 2) Breadth‑first
var bf = root.CreateBreadthFirstIterator();
Console.WriteLine("Breadth‑first traversal:");
while (bf.HasNext())
    Console.WriteLine("  " + bf.Next().GetType().Name);

Console.WriteLine();




// Рендеринг HTML
Console.WriteLine("Rendered HTML:");
Console.WriteLine(root.OuterHTML());

// State
para.SetState(new DisabledState());
try { para.AddChild(new LightTextNode("додано1")); }
catch (Exception ex) { Console.WriteLine(ex.Message); }


para.SetState(new EnabledState());
para.AddChild(new LightTextNode("додано2"));
Console.WriteLine("Після EnabledState:");
Console.WriteLine(root.OuterHTML());

// Template
var renderer = new DefaultElementRenderer();
Console.WriteLine("=== Template Method Rendering with Debug ===");
Console.WriteLine(renderer.Render(root));

para.AddClass("root");
root.AddChild(para);


// Visitor
var vis = new ElementCountVisitor();
var cssVisitor = new CssClassCollectorVisitor();

root.Accept(vis);
root.Accept(cssVisitor);

Console.WriteLine($"Elements: {vis.Elements}, Texts: {vis.Texts}");
Console.WriteLine("CSS-класи:");
foreach (var entry in cssVisitor.ClassCounts)
{
    Console.WriteLine($" • {entry.Key}: {entry.Value} раз(и)");
}
Console.WriteLine("");
// Рендеринг HTML
Console.WriteLine("Rendered HTML:");
Console.WriteLine(root.OuterHTML());

