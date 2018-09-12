using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingTermInArithmeticProgression
{
    class Program
    {
        static int term(List<int> list)
        {
            //calculate the number with which each list item is increased
            int diff = (list.Last() - list[0]) / list.Count;

            //this will be the missing term
            int res = 0;

            for (int i = 0; i <= list.Count; i++)
            {
                //if the difference between the next number and the current number
                //is not == to diff
                if (list[i + 1] - list[i] != diff)
                {
                    //found the missing item
                    res = list[i] + diff;
                    //break the loop so it doesn't do extra work for nothing
                    break;
                }
            }
            //return
            return res;

        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            //List<int> list = new List<int>() { 0, 5, 10, 20, 25 };
            //List<int> list = new List<int>() { 1040, 1220, 1580 };

            Console.WriteLine(term(list));
        }
    }
}
