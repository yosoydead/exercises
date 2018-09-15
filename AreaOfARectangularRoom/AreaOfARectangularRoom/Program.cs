using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfARectangularRoom
{
    class Program
    {
        const double toMeterFactor = 0.09290304;
        const double toFeetFactor = 10.7639104;
        static bool verify(string x)
        {
            if (string.IsNullOrEmpty(x) ||
                string.IsNullOrWhiteSpace(x) ||
                x.Any(char.IsLetter) ||
                x.Any(char.IsPunctuation) ||
                int.Parse(x) <= 1)
            {
                Console.WriteLine("Invalid input.");
                return false;
            }
            return true;
        }

        static void feet()
        {
            int length, width, area;
            Console.Write("What is the length of the room in feet? ");
            var l = Console.ReadLine();
            while (verify(l) == false)
            {
                l = Console.ReadLine();
            }

            Console.Write("What is the width of the room in feet? ");
            var w = Console.ReadLine();
            while (verify(w) == false)
            {
                w = Console.ReadLine();
            }

            length = Convert.ToInt32(l);
            width = Convert.ToInt32(w);
            area = length * width;
            double areaInMeters = area * toMeterFactor;

            Console.WriteLine($"The area is {area} feet or {areaInMeters} meters.");
        }

        static void meters()
        {
            int length, width, area;
            Console.Write("What is the length of the room in meters? ");
            var l = Console.ReadLine();
            while (verify(l) == false)
            {
                l = Console.ReadLine();
            }

            Console.Write("What is the width of the room in meters? ");
            var w = Console.ReadLine();
            while (verify(w) == false)
            {
                w = Console.ReadLine();
            }

            length = Convert.ToInt32(l);
            width = Convert.ToInt32(w);
            area = length * width;
            double areaInFeet = area * toFeetFactor;

            Console.WriteLine($"The area is {area} meters or {areaInFeet} feet.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate area a room area in feet or meters. What is your choice? ");
            string input = Console.ReadLine();

            if (input == "feet")
            {
                feet();
            }else if(input == "meters")
            {
                meters();
            }

        }
    }
}
