using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        /* 
         * if number is a multiple of 3 print fizz
         * if number is a multiple of 5 print buzz
         * if number is a multiple of 3 and 5 print fizzbuzz
         */

        
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            foreach (var item in arr)
            {
                //Console.WriteLine(item);
                if((item % 3 == 0 && item % 5 == 0))
                    Console.WriteLine("fizzbuzz");
                else if(item % 5 == 0)
                    Console.WriteLine("buzz");
                else if(item % 3 == 0)
                    Console.WriteLine("fizz");
                else
                    Console.WriteLine(item);
            }
        }
    }
}
