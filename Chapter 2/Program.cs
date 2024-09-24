using System;

class ProjectedRaisesInteractive
{
    const double RaisePercentage = 0.04; // 4 percent raise

    static void Main(string[] args)
    {
        // Declare variables for current salaries
        double salary1, salary2, salary3;

        // Accept user input for current salaries
        Console.Write("Enter the current salary for Employee 1: ");
        salary1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the current salary for Employee 2: ");
        salary2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the current salary for Employee 3: ");
        salary3 = Convert.ToDouble(Console.ReadLine());

        // Calculate next year's salaries
        double nextYearSalary1 = salary1 * (1 + RaisePercentage);
        double nextYearSalary2 = salary2 * (1 + RaisePercentage);
        double nextYearSalary3 = salary3 * (1 + RaisePercentage);

        // Display the results
        Console.WriteLine($"Next year's salary for Employee 1: {nextYearSalary1:C}");
        Console.WriteLine($"Next year's salary for Employee 2: {nextYearSalary2:C}");
        Console.WriteLine($"Next year's salary for Employee 3: {nextYearSalary3:C}");
    }
}