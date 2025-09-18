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

            Car2 volvo = new Car2();   
            volvo.Color = "White";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 250;
            ferrari.HorsePower = 180;
            ferrari.CarType = CarType.Hybrid;

            ferrari.ShowInfo();
            ferrari.Drive();

            volvo.ShowInfo();
            volvo.Drive();//

        }
    }
}
