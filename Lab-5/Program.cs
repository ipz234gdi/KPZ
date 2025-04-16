using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;
using BehavioralPatterns.Iterators;



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
