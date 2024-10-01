using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Extensions;

public static class TriangleExtensions
{
    public static bool IsTriangleRight(this IFigure? figure)
    {
        if (figure == null) 
            throw new ArgumentNullException(nameof(figure), "Figure cannot be null.");

        if (figure is Triangle triangle)
        {
            double[] sortedSides = new double[] { triangle.FirstSide, triangle.SecondSide, triangle.ThirdSide };
            Array.Sort(sortedSides);
            return Math.Abs(sortedSides[2] * sortedSides[2] -
                            (sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1])) < 1e-14;
        }
        
        throw new ArgumentException("Figure must be a triangle.", nameof(figure));
    }
}