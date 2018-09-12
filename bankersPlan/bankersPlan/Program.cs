using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankersPlan
{
    class Program
    {

        public static bool f(int sum, double  p , int c0, int n, double i) {
            p = p / 100;
            i = i / 100;

            for (int j = 2; j <= n; j++)
            {
                sum = (int)Math.Truncate((sum + (p * sum)) - c0);
                c0 = (int)Math.Truncate(c0 + (c0*i));
            }

            return (sum >= 0) ? true : false;
        }
        static void Main(string[] args)
        {
            //double sum = 100000;
            //const double interest = 0.01;
            //const double inflation = 0.01;
            //double withdraw = 9185;
            //int n = 12;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"year = {i},sum = {sum}, current withdraw = {withdraw}.");
            //    sum = Math.Truncate((sum + (interest * sum)) - withdraw);
            //    withdraw = Math.Truncate(withdraw + (withdraw * inflation));
            //}

            Console.WriteLine(f(100000,1,2000,15,1));
            //Console.WriteLine(f(100000, 1, 10000, 10, 1));
            Console.WriteLine(f(100000, 1, 9185, 12, 1));
            Console.WriteLine(f(100000000, 1, 100000, 50, 1));
            Console.WriteLine(f(100000000, 1.5, 10000000, 50, 1));
            Console.WriteLine(f(100000000, 5, 1000000, 50, 1));
        }
    }
}
