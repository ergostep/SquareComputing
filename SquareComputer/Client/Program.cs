using Client;
using SquareComputer;
using System.Runtime.CompilerServices;

var triangle = new Triangle(3, 4, 5);
var circle = new Circle(1);
var rectangle = new Rectangle(3, 4);
var squareComputer = new SquareCalculator();

var figures = new List<IFigure>() { triangle, circle, rectangle };

foreach (var figure in figures)
{
    Console.WriteLine($"Square for {figure.GetType()} is {squareComputer.ComputeSquare(figure)}");
}

Console.WriteLine("--------------------Random figures------------------------------------------");

for (int i = 0; i < 10; i++)
{
    IFigure figure = FigureRandomizer.GetRandomFigure();
    Console.WriteLine($"{i} - {figure.GetType()}. Square is {squareComputer.ComputeSquare(figure)}");
}
