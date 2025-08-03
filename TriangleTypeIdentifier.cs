using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("=== Triangle Type Identifier ===");
        double a = GetPositiveDouble("Enter side 1: ");
        double b = GetPositiveDouble("Enter side 2: ");
        double c = GetPositiveDouble("Enter side 3: ");

        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("The given sides do NOT form a valid triangle.");
            return;
        }

        string type;
        if (AreEqual(a, b) && AreEqual(b, c))
            type = "Equilateral";
        else if (AreEqual(a, b) || AreEqual(b, c) || AreEqual(a, c))
            type = "Isosceles";
        else
            type = "Scalene";

        Console.WriteLine($"Sides: {a}, {b}, {c} => Triangle type: {type}");
    }

    static double GetPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;
            Console.WriteLine("Please enter a positive number.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static bool AreEqual(double x, double y)
    {
        const double eps = 1e-6;
        return Math.Abs(x - y) < eps;
    }
}
