using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Grade Calculator ===");
        int grade = GetIntInRange("Enter numerical grade (0-100): ", 0, 100);

        string letter;
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        Console.WriteLine($"Numerical grade: {grade} => Letter grade: {letter}");
    }

    static int GetIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"Please enter an integer between {min} and {max}.");
        }
    }
}
