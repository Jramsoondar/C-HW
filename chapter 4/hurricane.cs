using System;
using static System.Console;

class Hurricane
{
    static void Main(string[] args)
    {
        Console.Write("Enter the sustained wind speed (in miles per hour): ");

        try
        {
            double windSpeed = double.Parse(Console.ReadLine());
            string category = ClassifyHurricane(windSpeed);
            Console.WriteLine($"The hurricane category is: {category}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    static string ClassifyHurricane(double windSpeed)
    {
        if (windSpeed < 74)
        {
            return "Tropical Storm";
        }
        else if (windSpeed < 96)
        {
            return "Category 1 Hurricane";
        }
        else if (windSpeed < 111)
        {
            return "Category 2 Hurricane";
        }
        else if (windSpeed < 130)
        {
            return "Category 3 Hurricane";
        }
        else if (windSpeed < 157)
        {
            return "Category 4 Hurricane";
        }
        else
        {
            return "Category 5 Hurricane";
        }
    }
}