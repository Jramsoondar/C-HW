using System;
using static System.Console;

class PaintingEstimate
{
    static void Main()
    {
        // Prompt user for room dimensions
        WriteLine("Enter the length of the room in feet: ");
        double length = Convert.ToDouble(Console.ReadLine());

        WriteLine("Enter the width of the room in feet: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Call method to calculate cost
        double cost = CalculatePaintingCost(length, width);

        // Display the result
        WriteLine($"The cost of painting the room is: ${cost:F2}");
    }

    static double CalculatePaintingCost(double length, double width)
    {
        // Constants
        const double ceilingHeight = 9.0; // 9-foot ceilings
        const double costPerSquareFoot = 6.0; // Cost per square foot

        // Calculate the area of the four walls
        double wallArea = 2 * (length * ceilingHeight) + 2 * (width * ceilingHeight);

        // Calculate total cost
        double totalCost = wallArea * costPerSquareFoot;

        return totalCost;
    }
}