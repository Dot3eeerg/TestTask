using TestTask.Extensions;
using TestTask.Factory;
using TestTask.Interfaces;
using TestTask.Services;

IShapeAreaCalculator shapeAreaCalculator = new ShapeAreaCalculator();

IFigure triangle = FigureFactory.CreateTriangleShape(3, 4, 5);
Console.WriteLine($"Triangle area = {shapeAreaCalculator.GetArea(triangle)}");
bool isRight = triangle.IsTriangleRight();
Console.WriteLine($"Triangle is right? -> {isRight}");

IFigure triangle2 = FigureFactory.CreateTriangleShape(3, 4, 6);
Console.WriteLine($"Triangle area = {shapeAreaCalculator.GetArea(triangle2)}");
bool isRight2 = triangle.IsTriangleRight();
Console.WriteLine($"Triangle is right? -> {isRight2}");

IFigure circle = FigureFactory.CreateCircleShape(3);
Console.WriteLine($"Circle area = {shapeAreaCalculator.GetArea(circle)}");
bool isCircleRight = circle.IsTriangleRight();
Console.WriteLine(isCircleRight);
