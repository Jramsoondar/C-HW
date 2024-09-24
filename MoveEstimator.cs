namespace mainArray;

using System;

class MoveEstimator
{
    const decimal BaseRate = 200m;  // Base rate for the move
    const decimal HourlyRate = 150m; // Rate per hour
    const decimal MileRate = 2m;     // Rate per mile

    static void Main(string[] args)
    {
        // Prompt user for input
        Console.Write("Enter the number of hours for the move: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of miles for the move: ");
        int miles = Convert.ToInt32(Console.ReadLine());

        // Calculate the total moving fee
        decimal totalFee = BaseRate + (HourlyRate * hours) + (MileRate * miles);

        // Display the total moving fee
        Console.WriteLine($"The total moving fee is: {totalFee:C}");
    }
}