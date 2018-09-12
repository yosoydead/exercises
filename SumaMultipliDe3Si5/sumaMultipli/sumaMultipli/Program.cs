using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaMultipli
{
    class Program
    {
        /*or
         return Enumerable.Range(0,n).Where(e => e% 3 ==0 || e% 5 == 0).Sum();
             */
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 25; i++)
            {
                if ( i % 3 == 0 || i % 5 == 0) {
                    Console.WriteLine("i = " + i);
                    sum += i;
                }
            }
            Console.WriteLine("sum " + sum);
        }
    }
}
