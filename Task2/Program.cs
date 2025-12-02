namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomDelegate.Calculate calc = CustomDelegate.Add;
            Console.WriteLine("Addition: " + calc(10, 5));

            calc = CustomDelegate.Subtract;
            Console.WriteLine("Subtraction: " + calc(10, 5));


            Console.WriteLine("\nDiscount Strategy Example (Question 2)\n");

            CustomDelegate.DiscountStrategy discount;

            discount = CustomDelegate.FestivalDiscount;
            Console.WriteLine("Festival Discount: " + discount(1000));

            discount = CustomDelegate.SeasonalDiscount;
            Console.WriteLine("Seasonal Discount: " + discount(1000));

            discount = CustomDelegate.NoDiscount;
            Console.WriteLine("No Discount: " + discount(1000));
        }
    }
}
