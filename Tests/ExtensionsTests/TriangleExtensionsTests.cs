using TestTask.Interfaces;
using TestTask.Models;
using TestTask.Extensions;

namespace Tests.ExtensionsTests;

public class TriangleExtensionsTests
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 5, 5, false)]
    public void Triangle_IsRightTriangle_ReturnExpectedResult(double sideA, double sideB, double sideC, bool expectedResult)
    {
        // Arrange
        IFigure triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsTriangleRight(); // Use the extension method

        // Assert
        Assert.Equal(expectedResult, isRightTriangle);
    }

    [Fact]
    public void Circle_IsRightTriangle_ThrowArgumentException()
    {
        // Arrange
        IFigure circle = new Circle(3);
        
        // Act and Assert
        Assert.Throws<ArgumentException>(() => circle.IsTriangleRight());
    }

    [Fact]
    public void Null_IsRightTriangle_ThrowArgumentException()
    {
        // Arrange
        IFigure triangle = null;
        
        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => triangle.IsTriangleRight());
    }
}