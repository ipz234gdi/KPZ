using ICSupportHandler;
using CLevel1Support;
using CLevel2Support;
using CLevel3Support;
using CLevel4Support;

//task2
using DesignPatterns.Mediator;

//task3
using CLightElementNode;
using CLightTextNode;

//task4
using CImageElement;
using CNetworkImageLoader;
using CFileImageLoader;

//task5
using CTextDocument;
using CTextEditor;

//Task1
ISupportHandler level1 = new Level1Support();
ISupportHandler level2 = new Level2Support();
ISupportHandler level3 = new Level3Support();
ISupportHandler level4 = new Level4Support();

// Побудова ланцюжка
level1.SetNext(level2);
level2.SetNext(level3);
level3.SetNext(level4);

// РОЗКОМІТИТИ ЦЕЙ КОД ДЛЯ ПЕРЕВІРКИ ПЕРШОГО ЗАВДАННЯ

// while (true)
// {
//     Console.Write("Describe your issue (or type 'exit'): ");
//     string? issue = Console.ReadLine();

//     if (string.IsNullOrWhiteSpace(issue)) continue;

//     if (issue.Trim().ToLower() == "exit")
//         break;

//     Console.WriteLine($"Your problem is - {issue}");

//     bool resolved = level1.Handle(issue);

//     if (!resolved)
//     {
//         Console.WriteLine("No one could resolve your issue. Please try again.\n");
//     }
// }

//Task2
Console.WriteLine("\nTask2");
var runway1 = new Runway();
var runway2 = new Runway();

var mediator = new CommandCentre(new[] { runway1, runway2 });

var aircraft1 = new Aircraft("Boeing-737", 130, mediator);
var aircraft2 = new Aircraft("Airbus-A320", 110, mediator);

mediator.RegisterAircraft(aircraft1);
mediator.RegisterAircraft(aircraft2);

aircraft1.RequestLanding();
aircraft2.RequestLanding();

aircraft1.RequestTakeOff();

aircraft2.RequestTakeOff();

Console.WriteLine("Simulation complete.");


//Task3
Console.WriteLine("\nTask3");
var div = new LightElementNode("div", isBlock: true, isSelfClosing: false);
div.AddClass("container");

div.AddChild(new LightTextNode("Натисни мене!"));

div.AddEventListener("click", (target) =>
{
    Console.WriteLine($"[Click] Елемент <{target.InnerHTML().Trim()}> був клікнутий.");
});

div.AddEventListener("mouseover", (target) =>
{
    Console.WriteLine($"[Mouseover] Наведено на елемент <{target.InnerHTML().Trim()}>.");
});

Console.WriteLine("HTML:\n" + div.OuterHTML());

// Симулюємо події
div.TriggerEvent("click");
div.TriggerEvent("mouseover");
div.TriggerEvent("keydown"); // (Перевірка) подія без слухачів


// Task4
Console.WriteLine("\nTask4");
string localPath = "images/photo.png";
string urlPath = "https://example.com/photo.png";

var fileLoader = new FileImageLoader();
var networkLoader = new NetworkImageLoader();

var localImage = new ImageElement(localPath, fileLoader);
var networkImage = new ImageElement(urlPath, networkLoader);

Console.WriteLine("Local image:");
localImage.Display();

Console.WriteLine("\nNetwork image:");
networkImage.Display();

Console.WriteLine("\nSwitching strategy:");
localImage.SetLoader(networkLoader);
localImage.Display();

// Task5
Console.WriteLine("\nTask5");

var doc = new TextDocument("Початковий текст.");
var editor = new TextEditor(doc);

editor.ShowDocument();

editor.TypeText(" Додаємо речення.");
editor.ShowDocument();

editor.TypeText(" Ще одне.");
editor.ShowDocument();

Console.WriteLine("\n--- Undo ---");
editor.Undo();
editor.ShowDocument();

Console.WriteLine("\n--- Undo ---");
editor.Undo();
editor.ShowDocument();

Console.WriteLine("\n--- Undo (None) ---");
editor.Undo();
