

namespace Essential_3_2
{
    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string HomePort { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string homePort)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            HomePort = homePort;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Ship, Passengers: {Passengers}, Home Port: {HomePort}");
        }

    }
}
