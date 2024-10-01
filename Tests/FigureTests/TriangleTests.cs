using TestTask.Interfaces;
using TestTask.Models;

namespace Tests.FigureTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(10, 20, 15, 72.6184)]
    public void Triangle_CalculateArea_ReturnExpectedArea(double firstSide, double secondSide, double thirdSide, double expectedArea)
    {
        // Arrange
        IFigure triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // Act
        double area = triangle.CalculateArea();
        
        // Assert
        Assert.Equal(expectedArea, area, precision: 4);
    }
    
    [Fact]
    public void Triangle_NegativeSide_ThrowArgumentException()
    {
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));
    }

    [Fact]
    public void Triangle_SumOfTwoSidesIsLessThenTheThird_ThrowArgumentException()
    {
        // Act and Assert
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 9));
    }
}