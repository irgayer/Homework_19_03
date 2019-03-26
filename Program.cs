using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework_19_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.WriteLine("------------------------");
            Exercise2();
        }
        static void Exercise1()
        {
            Type t = typeof(Console);
            var methodInfo = t.GetMethods();

            foreach(var c in methodInfo)
            {
                var parametrInfo = c.GetParameters();
                for(int i = 0; i < parametrInfo.Length; i++)
                {
                    Console.Write($"{parametrInfo[i].ParameterType.Name} {parametrInfo[0].Name}");
                }
                Console.WriteLine($"{c.ReturnType.Name} {c.Name}");
            }
        }
        static void Exercise2()
        {
            Car car = new Car()
            {
                Name = "Ferrari 404",
                MaxSpeed = 321,
                Weight = 2500,
                Color = "Red",
                CountOfSeats = 2,
                Cost = 250000
            };
            Type t = car.GetType();
            foreach(var mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.ReturnType.Name} {mi.Name}");
            }
            foreach(var pi in t.GetProperties())
            {
                Console.WriteLine($"{pi.PropertyType.Name} {pi.Name}");
            }
        }
    }
}
