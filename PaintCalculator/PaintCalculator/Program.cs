using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalculator
{
    class Program
    {
        const double feetToMeter = 0.09290304;
        const double meterToFeet = 10.76391041671;
        const double aGallonCoversFt = 350;

        static Verify vf = new Verify();

        //just function to print to the console easier
        static void simonSays(string s) => Console.WriteLine(s);

        //take input for a certain measurement
        static string Measurement()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var l = Console.ReadLine();
            //it also checks to see if the input is an int
            while (vf.verify(l) == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                l = Console.ReadLine();
            }
            Console.ResetColor();
            return l;
            
        }

        //just convert the string value to double
        static double converToDouble(string measure)
        {
            double toDoubleMeasure = double.Parse(measure);

            return toDoubleMeasure;
        }

        static double calculateGallons(double area, double feetPerGaloon)
        {
            /* 
             1 gallon covers 350 square ft

             if 350ft ...... 1 gallon
             for area ft...... x gallons

             => 350/area = 1 gallon/x

            calculate the unknown value => x = area * 1gallon/ 350ft
             */

            double result = (area * 1) / feetPerGaloon;
            return Math.Ceiling(result);
        }

        //self explanatory
        static void conventionalRoof()
        {
            double width, length, gallonsNeeded, area;

            simonSays("Lets calculate how many gallons you need.");
            simonSays("Length of the room: ");
            length = converToDouble(Measurement());

            simonSays("Width of the room: ");
            width = converToDouble(Measurement());

            area = length * width;
            gallonsNeeded = calculateGallons(area, aGallonCoversFt);

            simonSays($"So the length of the room is #{length} and the width is #{width} for a total area of #{area} square ft. Keep in mind that a gallon of paint covers ~#{aGallonCoversFt} square ft.");
            simonSays($"If you need 1 gallon for ~350ft, then for your #{area} square ft area you will need #{gallonsNeeded} gallons. :)");

        }

        //self explanatory
        static void roundRoof()
        {
            double diameter, area, radius;
            //conventionalRoof();
            simonSays("Lets see how many gallons of paint you need for a round room.");
            simonSays("What is the diameter of the room? ");
            diameter = converToDouble(Measurement());

            radius = diameter / 2;

            area = Math.Ceiling(Math.PI * Math.Pow(radius, 2));

            simonSays($"The area of your room is ~{area}. You will need ~{calculateGallons(area, aGallonCoversFt)} gallons of paint.");
        }
        
        static void Main(string[] args)
        {
            conventionalRoof();
            roundRoof();

        }
    }

    public interface IVerify
    {
        bool verify(string x);
    }
    //a class that checks to see if the input is an int or not
    //it if is an int, returns true
    class Verify: IVerify
    {
        public bool verify(string x)
        {
            if (string.IsNullOrEmpty(x) ||
                string.IsNullOrWhiteSpace(x) ||
                x.Any(char.IsLetter) ||
                x.Any(char.IsPunctuation)||
                x.Any(char.IsSeparator)||
                Int32.Parse(x) < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Btw i dont think a room can be smaller than 2X2 square.");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
