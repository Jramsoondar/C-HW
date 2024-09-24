// See https://aka.ms/new-console-template for more information
//Convert the InchesToCentimeters program to an interactive application named 
//InchesToCentimeterslnteractive. Instead of assigning a value to the inches variable, 
//accept the value from the user as input.
using System;
using static System.Console;
class InchesToCentimeters
{
    static void Main(string[] args)
    {
        const double CENTI = 2.54;
        WriteLine("Enter the inches");
        double inches = Convert.ToInt32(ReadLine());
        double totalCenti = inches * CENTI;

        WriteLine("There are {0} centimeters ",totalCenti );


    }
}