using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_03
{
    public class Car
    {
        public string Name { get; set; }
        public double MaxSpeed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public int CountOfSeats { get; set; }
        public int Cost { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Max speed : {MaxSpeed}Km/H");
            Console.WriteLine($"Weight : {Weight}Kg");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Count of Seats : {CountOfSeats}");
            Console.WriteLine($"Cost : {Cost}$");
        }
        public void ChangeColor(string newColor)
        {
            if (!string.IsNullOrWhiteSpace(newColor))
            {
                Color = newColor;
                Console.WriteLine("Color changed!");
            }
            else Console.WriteLine("Error");
        }
        public void UpgradeEngine(double plusSpeed)
        {
            if(plusSpeed >= 0)
            {
                MaxSpeed += plusSpeed;
                Console.WriteLine("Engine upgraded");
            }
            else Console.WriteLine("Error");
        }
    }
}
