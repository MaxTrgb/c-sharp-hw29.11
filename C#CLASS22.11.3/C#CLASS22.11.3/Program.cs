namespace C_CLASS22._11._3
{

    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Start();
            car.Move();
            car.Brake();
            car.Stop();

            Bicycle bicycle = new Bicycle();
            bicycle.Move();
            bicycle.Brake();
        }
    }
}