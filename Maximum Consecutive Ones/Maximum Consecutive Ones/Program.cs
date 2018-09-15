using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Consecutive_Ones
{
    class Program
    {
        /*
            This is not that efficient. Traverse the entire array and count.
         */
        static int maxOnes(int[] arr)
        {
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                   // isOne = true;
                    count++;
                }
                if (arr[i] == 0)
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    //isOne = false;
                    count = 0;
                }

                //if(i == arr.Length - 1)
                //{
                //    if (count > maxCount)
                //        maxCount = count;
                //}
            }
            //i do this because after the last loop execution, the loops breaks and it doesn't check
            //if the count exceeded the maxCount
            return Math.Max(count, maxCount);

        }

        /*
            This is somewhat of a more efficient way of doing it.
            Have two pointers. One at the first element of the array, one of the second.
            Each pointers moves accordingly and if they encounter a 1, they count and move on.
         */
        static int maxOnes2(int[] arr)
        {
            int len = arr.Length - 1;
            int low = 0;
            int high = len;

            int lowCount = 0;
            int lowMax = 0;

            int highCount = 0;
            int highMax = 0;


            while (low <= high) {

                if (arr[low] == 1)
                {
                    lowCount++;
                    low++;
                }
                else
                {
                    if (lowCount > lowMax)
                        lowMax = lowCount;

                    lowCount = 0;
                    low++;
                }



                if (arr[high] == 1)
                {
                    highCount++;
                    high--;
                }else
                {
                    if (highCount > highMax)
                        highMax = highCount;

                    highCount = 0;
                    high--;
                }

                   
            }
            if (lowCount > lowMax)
                lowMax = lowCount;

            if (highCount > highMax)
                highMax = highCount;

            return Math.Max(lowMax,highMax);


        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 0, 1, 1,0,0,0,1,1,0,1,1,1,0,1,0,0,0,1 };
            
            int bla = maxOnes2(arr);
            Console.WriteLine(bla);
        }
    }
}
