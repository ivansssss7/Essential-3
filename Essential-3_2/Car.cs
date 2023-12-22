

namespace Essential_3_2
{
    class Car:Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
            : base(x, y, price, speed, year)
        {
        }
        // Перевизначений метод виводу інформації про Car
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Type: Car");
        }
    }
}
