using System;

class ForLoop
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            double squareRoot = Math.Sqrt(i);
            Console.WriteLine("Number: {0}, Square Root: {1}", i, squareRoot);
        }
    }
}