// See https://aka.ms/new-console-template for more information

using DrawingPackage.Widgets;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Requested Drawing");
Console.WriteLine("----------------------------------------------------------------");

var rectangle = new Rectangle(10, 10, 30, 40);
var square = new Square(15, 30, 35);
var eclipse = new Eclipse(100, 150, 300, 200);
var circle = new Circle(1, 1, 300);
var textbox = new Textbox(5, 5, 200, 100, "sample text");

var widgets = new List<IWidget> { rectangle, square, eclipse, circle, textbox };
foreach (var widget in widgets)
{
    Console.WriteLine(widget.Print());
}
Console.WriteLine("----------------------------------------------------------------");
