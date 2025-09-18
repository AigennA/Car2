namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car2 ferrari = new Car2();
            ferrari.Color = "Red";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 350;
            ferrari.HorsePower = 180;
            ferrari.CarType = CarType.Gas;
            ferrari.IsFasterThan(ferrari);

            Car2 volvo = new Car2();   
            volvo.Color = "White";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 250;
            ferrari.HorsePower = 180;
            ferrari.CarType = CarType.Hybrid;
            volvo.IsFasterThan(ferrari);

            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();

            volvo.ShowInfo();
            volvo.Drive();
            volvo.Honk();
            volvo.Fuel();

        }
    }
}
