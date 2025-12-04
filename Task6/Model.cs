namespace Task6;

public class Tour(string customerName, string destination, double price, int durationInDays, bool isInternational)
{
    public string CustomerName { get; set; } = customerName;
    public string Destination { get; set; } = destination;
    public double Price { get; set; } = price;
    public int DurationInDays { get; set; } = durationInDays;
    public bool IsInternational { get; set; } = isInternational;
}