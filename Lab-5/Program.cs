using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;
using BehavioralPatterns.Template;
using BehavioralPatterns.Visitor;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
root.AddChild(para);


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

