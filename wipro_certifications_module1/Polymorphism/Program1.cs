using System;
class AreaCalculator
{
    public void  CalculateArea(double length, double width)
    {
        double rectangleArea= length * width;
        Console.WriteLine($"Area of Rectangle: {rectangleArea}");
    }
    public void CalculateArea(double radius)
    {
        double circleArea = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {circleArea}");
    }
    public void CalculateArea(double baseLength, double height, bool isTriangle)
    {
        if (isTriangle)
        {
            double triangleArea = 0.5 * baseLength * height;
            Console.WriteLine($"Area of Triangle: {triangleArea}");
        }
        else
        {
            Console.WriteLine("Invalid parameters for triangle area calculation.");
        }
    }
}
class Program1
{
    static void Main()
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        Console.WriteLine("Calculating area of a rectangle:");
        areaCalculator.CalculateArea(5.0, 3.0);
        Console.WriteLine("\nCalculating area of a circle:");
        areaCalculator.CalculateArea(4.0);
        Console.WriteLine("\nCalculating area of a triangle:");
        areaCalculator.CalculateArea(6.0, 4.0, true);
    }
}

