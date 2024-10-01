using TestTask.Interfaces;

namespace TestTask.Services;

/// <summary>
/// Сервис для вычисления площади фигур
/// </summary>
public class ShapeAreaCalculator : IShapeAreaCalculator
{
    public double GetArea(IFigure figure) => figure.CalculateArea();
}