using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class Car2
    {
        public string Brand;
        public string Color;
        public int MaxSpeed;

        public void ShowInfo()
        {
            Console.WriteLine($"CarInfo: {Brand}, {Color}, MaxSpeed: {MaxSpeed}");
        }

        public void Drive() { 
            Console.WriteLine("The Car Is Driving");
        }
    }
}
