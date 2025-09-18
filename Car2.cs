using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class Car2
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;
        public int HorsePower;
        public CarType CarType;

        // Add a public constructor to fix CS0122
        public Car2(string brand, string color, int maxSpeed, int horsePower, CarType carType)
        {
            Brand = brand;
            Color = color;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower;
            CarType = carType;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"CarInfo: {Brand}, {Color}, MaxSpeed: {MaxSpeed}");
        }

        public void Drive() { 
            Console.WriteLine("The Car Is Driving");
        }

        public void Honk() { 
            Console.WriteLine("Honk Honk! ");
        }

        public void Fuel() {
            Console.WriteLine($"Car is of type: {CarType}");
            switch (CarType)
            {
                case CarType.Electric:
                    Console.WriteLine("Electric fuel");
                    break;
                case CarType.Gas:
                    Console.WriteLine("Gas fuel");
                    break;
                case CarType.Disel:
                    Console.WriteLine("Diesel fuel");
                    break;
                case CarType.Hybrid:
                    Console.WriteLine("Hybrid fuel");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }
        }

            

            public void IsFasterThan(Car2 otherCar)
            {
               if(otherCar.MaxSpeed > MaxSpeed)
                {
                    Console.WriteLine($"Car2 { otherCar.Brand} is the quickest.");
                }
               else if ( otherCar.MaxSpeed == MaxSpeed )
                {
                Console.WriteLine($"They are equal in speed");
                }
            else
            {
                Console.WriteLine($"Car2 {Brand} is quickest");
            }
        }
        }
}
