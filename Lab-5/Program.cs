using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;
using BehavioralPatterns.Visitor;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
para.AddClass("root");
root.AddChild(para);





// Рендеринг HTML
Console.WriteLine("Rendered HTML:");
Console.WriteLine(root.OuterHTML());
