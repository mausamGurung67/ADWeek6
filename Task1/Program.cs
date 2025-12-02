namespace Task1
{
    public class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public static double GetArea(double length, double breadth) => length * breadth;
        // {}
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";

    }
}
