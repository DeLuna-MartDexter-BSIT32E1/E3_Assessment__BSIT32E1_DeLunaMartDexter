using System;

class AreaofTriangle
{
    static void Main()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double heightValue = Convert.ToDouble(Console.ReadLine());

        double area = CalculateTriangleArea(baseValue, heightValue);

        Console.WriteLine($"The area of the triangle is: {area}");
    }

    static double CalculateTriangleArea(double baseValue, double heightValue)
    {
        return 0.5 * baseValue * heightValue;
    }
}