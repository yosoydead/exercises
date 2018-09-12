using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //there will be only one number different from the others
            int[] arr = new int[] { 1, 2, 2, 2 };
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //do the exclusive or operation so in the end only the
                //number that is not equal to the other will remain
                //if all the numbers were to be equal, result would remain 0
                result ^= arr[i];
            }
            Console.WriteLine(result);
        }
    }
}
