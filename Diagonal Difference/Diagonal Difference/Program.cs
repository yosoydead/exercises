using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = { new int[]{ 11,2,4}, new int[] { 4,5,6}, new int[] { 10,8,-12} };
            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    //Console.Write($"i:{i}, j:{j}, a[i][j]: {a[i][j]} ");
                    if(i == j) { Console.WriteLine(a[i][j]);
                        d1 += a[i][j];
                    }


                    if (j == a[i].Length - i - 1)
                    {
                        Console.WriteLine(a[i][j]);
                        d2 += a[i][j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"abs diff = {Math.Abs(d1-d2)}");
        }
    }
}
