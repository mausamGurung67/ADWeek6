using System;
using System.Linq;
using Task6;

class Program
{
    static void Main(string[] args)
    {
        Tour[] tours =
        [
            new("Mausam", "Pokhara", 8000, 3, false),
            new("Sita", "Bangkok", 45000, 5, true),
            new("Hari", "Chitwan", 12000, 4, false),
            new("Gopal", "Dubai", 60000, 6, true),
            new("Anita", "Lumbini", 15000, 5, false),
            new("Rahul", "Malaysia", 38000, 7, true),
        ];

        // -------------------------------
        // STEP 1: FILTER
        // -------------------------------
        var filteredTours = tours
            .Where(t => t.Price > 10000 && t.DurationInDays > 4);

        // -------------------------------
        // STEP 2: PROJECT / TRANSFORM
        // -------------------------------
        var projectedTours = filteredTours
            .Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                t.Price
            });

        // -------------------------------
        // STEP 3: SORT 
        // Domestic first → then International
        // Also sort by Price inside each category
        // -------------------------------
        var sortedTours = projectedTours
            .OrderBy(t => t.Category)     // Domestic first (D < I)
            .ThenBy(t => t.Price);

        // -------------------------------
        // STEP 4: DISPLAY RESULT
        // -------------------------------
        Console.WriteLine("\n=======================");
        Console.WriteLine("   Tour Summary Report");
        Console.WriteLine("=======================\n");

        foreach (var t in sortedTours)
        {
            Console.WriteLine($"Customer: {t.CustomerName}");
            Console.WriteLine($"Destination: {t.Destination}");
            Console.WriteLine($"Category: {t.Category}");
            Console.WriteLine($"Price: Rs. {t.Price}");
            Console.WriteLine("---------------------------");
        }
    }
}
