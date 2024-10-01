using TestTask.Interfaces;

namespace TestTask.Models;

public class Circle : IFigure
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero");
        
        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;
}