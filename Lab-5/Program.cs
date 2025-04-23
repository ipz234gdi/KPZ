using System;
using BehavioralPatterns;
using BehavioralPatterns.Composite;

using BehavioralPatterns.Commands;


var root = new LightElementNode("div");
root.AddClass("root");

var para = new LightElementNode("p");
para.AddChild(new LightTextNode("Привіт, світ!"));
root.AddChild(para);



















// Command
var mgr = new CommandManager();

// Додаємо параграф до root
var addParaCmd = new AddChildCommand(root, para);
mgr.ExecuteCommand(addParaCmd);
Console.WriteLine("Після додавання <p>:");
Console.WriteLine(root.OuterHTML());

// Додаємо клас 'highlight' до параграфа
var addClassCmd = new AddClassCommand(para, "highlight");
mgr.ExecuteCommand(addClassCmd);
Console.WriteLine("\nПісля додавання класу:");
Console.WriteLine(root.OuterHTML());

// Undo додавання класу
mgr.Undo();
Console.WriteLine("\nПісля Undo класу:");
Console.WriteLine(root.OuterHTML());

// Undo додавання параграфа
mgr.Undo();
Console.WriteLine("\nПісля Undo параграфа:");
Console.WriteLine(root.OuterHTML());

// Redo додавання параграфа
mgr.Redo();
Console.WriteLine("\nПісля Redo параграфа:");
Console.WriteLine(root.OuterHTML());

// Redo додавання класу
mgr.Redo();
Console.WriteLine("\nПісля Redo класу:");
Console.WriteLine(root.OuterHTML());


// Рендеринг HTML
// Console.WriteLine("Rendered HTML:");
// Console.WriteLine(root.OuterHTML());
