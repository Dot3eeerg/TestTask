namespace TestTask.Interfaces;

/// <summary>
/// Интерфейс для сервиса вычисления площади фигуры.
/// </summary>
public interface IShapeAreaCalculator
{
    double GetArea(IFigure figure);
}