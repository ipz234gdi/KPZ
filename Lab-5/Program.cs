using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;


using BehavioralPatterns.State;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
root.AddChild(para);


// State
para.SetState(new DisabledState());
try { para.AddChild(new LightTextNode("додано1")); }
catch (Exception ex) { Console.WriteLine(ex.Message); }


para.SetState(new EnabledState());
para.AddChild(new LightTextNode("додано2"));
Console.WriteLine("Після EnabledState:");
Console.WriteLine(root.OuterHTML());

// Рендеринг HTML
// Console.WriteLine("Rendered HTML:");
// Console.WriteLine(root.OuterHTML());
