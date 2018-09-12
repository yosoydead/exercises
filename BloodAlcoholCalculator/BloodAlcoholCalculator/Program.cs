using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputToBeNumbersVerify;

namespace BloodAlcoholCalculator
{
    class Program
    {
        const double forMen = 0.73;
        const double forWomen = 0.66;
        const double bloodAlcoholMaxLvl = 0.08;

        //custom class to check if the input is a number
        static Verify vf = new Verify();

        //ask for input and verify it
        static string input()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var l = Console.ReadLine();
            while (vf.verify(l) == false)
            {
                l = Console.ReadLine();
            }
            Console.ResetColor();
            return l;
        }

        //convert input to double
        static double toNr(string x) => double.Parse(x);

        //calculate the blood alcohol content
        static double BAC (double A, double W, double r, double H)
        {
            var bac = ((A * 5.14) / (W * r)) - .015 * H;
            return bac;
        }

        static void Main(string[] args)
        {
            int A, W, H;
            double r = 0;
            Console.WriteLine("Sex? M/F");
            var sex = Console.ReadLine();

            //update the alcohol distribution ratio 0.73 men, 0.66 women
            if (sex == "M")
            {
                r = forMen;
            }
            else if (sex == "F")
            {
                r = forWomen;
            }

            Console.WriteLine("Alcohol consumed? ");
            A = (int)toNr(input());

            Console.WriteLine("How much time since the last drink ?");
            H = (int)toNr(input());

            Console.WriteLine("Body weight? ");
            W = (int)toNr(input());

            Console.WriteLine($"alcohol ratio {BAC(A, W, r, H)}");

            if (BAC(A, W, r, H) > 0.08)
            {
                Console.WriteLine("Not legal");
            }
        }
    }
}
