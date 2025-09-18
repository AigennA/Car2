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

            Car2 volvo = new Car2();   
            volvo.Color = "White";
            volvo.Brand = "Volvo";
            volvo.MaxSpeed = 250;

            ferrari.ShowInfo();
            volvo.Drive();

            volvo.ShowInfo();
            ferrari.Drive();

        }
    }
}
