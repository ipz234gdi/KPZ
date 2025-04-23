using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;
using BehavioralPatterns.Template;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
root.AddChild(para);


// Template

var renderer = new DefaultElementRenderer();
Console.WriteLine("=== Template Method Rendering with Debug ===");
Console.WriteLine(renderer.Render(root));

// Рендеринг HTML
// Console.WriteLine("Rendered HTML:");
// Console.WriteLine(root.OuterHTML());
