using System;

public class House
{
    public int YearBuilt { get; set; }
    public double Size { get; set; }

    // Constructor
    public House(int yearBuilt, double size)
    {
        YearBuilt = yearBuilt;
        Size = size;
    }

    // Private helper method to calculate age
    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - YearBuilt;
    }

    // Property-like method to check if the house can be sold
    public bool CanBeSold()
    {
        int age = HowOld();
        return age > 15;
    }

    // Display house info
    public void ShowInfo()
    {
        Console.WriteLine("\n--- House Information ---");
        Console.WriteLine($"Year Built: {YearBuilt}");
        Console.WriteLine($"Size: {Size} sq.ft");
        Console.WriteLine($"Can be sold: {CanBeSold()}");
        Console.WriteLine();
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter the year the house was built: ");
        int yearBuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of the house (in sq.ft): ");
        double size = Convert.ToDouble(Console.ReadLine());

        House house = new House(yearBuilt, size);
        house.ShowInfo();
    }
}
