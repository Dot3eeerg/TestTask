using TestTask.Interfaces;
using TestTask.Models;

namespace Tests.FigureTests;

public class CircleTests
{
    [Fact]
    public void Circle_CalculateArea_ReturnCorrectArea()
    {
        // Arrange
        IFigure circle = new Circle(3);
        
        // Act
        double area = circle.CalculateArea();
        
        // Assert
        Assert.Equal(Math.PI * 3 * 3, area);
    }
    
    [Fact]
    public void Circle_NegativeRadius_ThrowArgumentException()
    {
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Circle(-3));
    }
}