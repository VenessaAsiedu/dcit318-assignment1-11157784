using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Ticket Price Calculator ===");
        int age = GetNonNegativeInt("Enter your age: ");

        decimal price = (age >= 65 || age <= 12) ? 7m : 10m;
        Console.WriteLine($"Age: {age} => Ticket price: GHC{price}");
    }

    static int GetNonNegativeInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= 0)
                return value;
            Console.WriteLine("Please enter a non-negative integer.");
        }
    }
}
