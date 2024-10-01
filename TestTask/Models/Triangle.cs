using TestTask.Interfaces;

namespace TestTask.Models;

public class Triangle: IFigure
{
    public readonly double FirstSide; 
    public readonly double SecondSide; 
    public readonly double ThirdSide; 
    
    
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentException("All triangle sides must be greater than zero");

        if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide ||
            secondSide + thirdSide <= firstSide)
            throw new ArgumentException("Sum of both sides must be greater than the third side");
        
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public double CalculateArea()
    {
        double p = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }
}
