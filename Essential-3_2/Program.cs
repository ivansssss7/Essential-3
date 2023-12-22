namespace Essential_3_2;

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Plane(40.7128, -74.0060, 1000000, 600, 2020, 30000, 250);
        Vehicle vehicle2 = new Car(34.0522, -118.2437, 50000, 150, 2018);
        Vehicle vehicle3 = new Ship(51.5074, -0.1278, 2000000, 50, 2015, 1500, "London");

        vehicle1.ShowInfo();
        vehicle2.ShowInfo();
        vehicle3.ShowInfo();
    }
}