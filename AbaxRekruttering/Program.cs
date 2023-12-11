namespace AbaxRekruttering
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car("NF123456", 147, 200, "Green", "Lett kjøretøy");
            var firstCarCopy = new Car("NF123456", 147, 200, "Green", "Lett kjøretøy");
            var secondCar = new Car("NF654321", 150, 195, "Blue", "Lett kjøretøy");
            var plane = new Plane("LN1234", 1000, 30, 2, 10, "Jetfly");
            var boat = new Boat("ABC123", 100, 30, 500);

            firstCar.PrintInfo();
            secondCar.PrintInfo();

            if (!firstCar.CheckIfTheSame(secondCar)) Console.WriteLine("They are not the same (FirstCar and SecondCar)");
            else Console.WriteLine("They are the same (FirstCar and SecondCar)");

            if (!firstCar.CheckIfTheSame(firstCarCopy)) Console.WriteLine("They are not the same (FirstCar and FirstCarCopy)");
            else Console.WriteLine("They are the same (FirstCar and FirstCarCopy)");

            plane.PrintInfo();

            plane.Drive();

            firstCar.Drive();

            boat.PrintInfo();
            boat.Drive();
        }
    }
}