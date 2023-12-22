
namespace Essential_3_2
{
    class Plane:Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }
        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Plane, Altitude: {Height}, Passengers: {Passengers}");
        }
    }
}
