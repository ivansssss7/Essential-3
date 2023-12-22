

namespace Essential_3_2
{
    class Vehicle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Vehicle Info: Coordinates ({X}, {Y}), Price: {Price}, Speed: {Speed}, Year: {Year}");
        }
    }
}
