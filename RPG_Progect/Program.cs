// task1
using CLogger;
using CFileWriter;
using CFileLoggerAdapter;

// task2
using CHero;
using CMage;
using CPaladin;
using CWarrior;
using CArmor;
using CArtifact;
using CWeapon;

// task3
using ICRenderer;
using AShape;
using CVectorRenderer;
using CRasterRenderer;
using CCircle;
using CTriangle;
using CSquare;

// task4
using CSmartTextChecker;
using CSmartTextReader;
using CSmartTextReaderLocker;

// task5
using CLightNode;
using CLightTextNode;
using CLightElementNode;

// task6
using CBookToHTMLConverter;
using CFlyweightFactory;



// Task1
Logger logger = new Logger();
FileWriter filewriter = new FileWriter();
FileLoggerAdapter fileloggeradapter = new FileLoggerAdapter(filewriter);

logger.Warn("Task1\n");
logger.Log("All systems operational.");
logger.Warn("Low memory!");
logger.Error("Critical system error!");

fileloggeradapter.Log("All systems operational.");
fileloggeradapter.Error("Low memory!");
fileloggeradapter.Warn("Critical system error!");

// Task2
logger.Warn("\nTask2");
Hero mage = new Mage();
Hero warrior = new Warrior();
Hero paladin = new Paladin();

void hero_logger(Hero hero)
{
    logger.Log("----------------------");
    logger.Log(hero.GetDescription());
    logger.Log("Power: " + hero.GetPower());
    logger.Log("HP: " + hero.GetHP());
    logger.Log("Armor: " + hero.GetArmor());
}

hero_logger(mage);
hero_logger(warrior);
hero_logger(paladin);

mage = new Artifact(mage);
warrior = new Weapon(warrior);
warrior = new Artifact(warrior);
paladin = new Armor(paladin);

hero_logger(mage);
hero_logger(warrior);
hero_logger(paladin);

// Task3
logger.Warn("\nTask3");
IRenderer vector = new VectorRenderer();
IRenderer raster = new RasterRenderer();

Shape circle = new Circle(raster);
Shape triangle = new Triangle(raster);
Shape square = new Square(raster);

void shapes_logger()
{
    logger.Log("----------------------");
    logger.Log(circle.Draw());
    logger.Log(triangle.Draw());
    logger.Log(square.Draw());
}

shapes_logger();

circle = new Circle(vector);
triangle = new Triangle(vector);
square = new Square(vector);

shapes_logger();

// Task4
logger.Warn("\nTask4");
SmartTextReader smarttextreader = new SmartTextReader();
SmartTextChecker smarttextchecker = new SmartTextChecker(smarttextreader);
SmartTextReaderLocker smarttextreaderlocker = new SmartTextReaderLocker(smarttextreader, ".*log.*");

smarttextchecker.ReadFile("log.txt");
logger.Log("----------------------");
smarttextreaderlocker.ReadFile("log.txt");
logger.Log("----------------------");
smarttextreaderlocker.ReadFile("Nice.txt");


// Task5
logger.Warn("\nTask5");
var div = new LightElementNode("div", true, false);
div.AddClass("container");
div.AddClass("header");

var ul = new LightElementNode("ul", true, false);
ul.AddClass("list");

var li1 = new LightElementNode("li", false, false);
li1.AddChild(new LightTextNode("Item 1"));

var li2 = new LightElementNode("li", false, false);
li2.AddChild(new LightTextNode("Item 2"));

ul.AddChild(li1);
ul.AddChild(li2);
div.AddChild(ul);

logger.Log($"Кількість дочірніх елементів div - {div.getCountClasses()}");
logger.Log(div.OuterHTML());

logger.Log($"Кількість дочірніх елементів ul - {ul.getCountClasses()}");
logger.Log(div.InnerHTML());


// Task6
logger.Warn("\nTask6");
string[] bookLines = File.ReadAllLines("book.txt");

var factory = new FlyweightFactory();
var converter = new BookToHTMLConverter(factory);

long before = GC.GetTotalMemory(true);

var htmlRoot = converter.Convert(bookLines);

long after = GC.GetTotalMemory(true);
long usedMemory = after - before;

logger.Log(htmlRoot.OuterHTML());
logger.Log($"\nMemory used per tree: {usedMemory} bytes");
logger.Log($"Flyweight unique tag objects in memory: {factory.CacheCount}");



