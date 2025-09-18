namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ferrari = new Car2("Ferrari", "Red", 380, 500, CarType.Gas);
           /* ferrari.Color = "Red";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 350;
            ferrari.HorsePower = 180;
            ferrari.CarType = CarType.Gas;
            ferrari.IsFasterThan(ferrari);*/

            var volvo = new Car2("Volvo", "White", 250, 180, CarType.Hybrid);   
            /*volvo.Color = "White";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 250;
            ferrari.HorsePower = 180;
            ferrari.CarType = CarType.Hybrid;
            volvo.IsFasterThan(ferrari);*/

            var tesla = new Car2("Tesla", "Black", 300, 400, CarType.Electric);


            ferrari.ShowInfo();
            ferrari.Drive();
            ferrari.Honk();
            ferrari.Fuel();

            volvo.ShowInfo();
            volvo.Drive();
            volvo.Honk();
            volvo.Fuel();

            tesla.ShowInfo();
            tesla.Drive();
            tesla.Honk();
            tesla.Fuel();

        }
    }
}
