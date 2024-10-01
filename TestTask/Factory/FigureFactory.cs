using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Factory;

public static class FigureFactory
{
    public static IFigure CreateCircleShape(double radius) => new Circle(radius);

    public static IFigure CreateTriangleShape(double firstSide, double secondSide, double thirdSide) =>
        new Triangle(firstSide, secondSide, thirdSide);
}