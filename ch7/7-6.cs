namespace ch7_3;

public class 7-6
{
     static void Main(string[] args)
    {
        Console.Write("Enter the number of books checked out: ");
        int numberOfBooks = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of days overdue: ");
        int daysOverdue = int.Parse(Console.ReadLine());

        // Call method to calculate and display the fine
        CalculateAndDisplayFine(numberOfBooks, daysOverdue);
    }

    static void CalculateAndDisplayFine(int numberOfBooks, int daysOverdue)
    {
        double fine = 0;

        if (daysOverdue > 0)
        {
            // Calculate fine for the first 7 days
            if (daysOverdue <= 7)
            {
                fine = numberOfBooks * daysOverdue * 0.10; // 10 cents per book per day
            }
            else
            {
                fine = numberOfBooks * 7 * 0.10; // Fine for the first 7 days
                fine += numberOfBooks * (daysOverdue - 7) * 0.20; // 20 cents per book per day for additional days
            }
        }

        Console.WriteLine($"The total fine for overdue books is: ${fine:F2}");
    }
}
