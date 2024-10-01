using TestTask.Interfaces;

namespace TestTask.Models;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero");
        
        _radius = radius;
    }

    public double CalculateArea() => Math.PI * _radius * _radius;
}