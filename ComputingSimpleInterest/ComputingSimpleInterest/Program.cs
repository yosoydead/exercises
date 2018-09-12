using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputToBeNumbersVerify;

namespace ComputingSimpleInterest
{
    class Program
    {
        //custom class to check if the input is a number
        static Verify vf = new Verify();
        static string input()
        {
            var l = Console.ReadLine();
            while (vf.verify(l) == false)
            {
                l = Console.ReadLine();
            }
            return l;
        }

        //convert the input into a double
        static double convertToDouble()
        {
            double result = double.Parse(input());
            return result;
        }

        //compute the simple interest
        static double simpleInterest(double p, double r, double t)
        {
            //simple interest is A = P(1 + r*t)
            //p = principal amount
            //r = annual rate of interest
            //t = number of years the amount is invested
            double result = p*(1 + (r * t));
            return result;
        }

        //percent convert
        static float transformToPercent(string x)
        {
            float result = float.Parse(x) / 100;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal: ");
            var principal = convertToDouble();
            Console.WriteLine("Enter the rate of interest: ");
            var x = Console.ReadLine();
            var rate = transformToPercent(x);
            Console.WriteLine("Enter the number of years: ");
            var time = convertToDouble();
            for (int i = 1; i <= time; i++)
            {
                Console.WriteLine($"Year {i}, rate {rate*100}, investment {simpleInterest(principal,rate,i)}");
            }
            Console.WriteLine($"After {time} years at {rate*100}%, the investment will be worth {simpleInterest(principal,rate,time):C}");
        }
    }
}
