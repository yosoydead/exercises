using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace permutations_my_way_
{
    /*
        first of all, i calculate the factorial for the length of the input array so i know
        how many permutations i need to do
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            string start = string.Format("{0:HH:mm:ss:ff tt}", DateTime.Now);

            //this will be the array that holds the values to be permuted
            int[] array = { 1,2,3,4,5,6,7};

            //create a new permutation object
            Permutation perm = new Permutation(array);
            //create the object that inherits the IVerify interface
            Verify vf = new Verify();
            //use the generate function
            perm.GeneratePermutation(vf);

            string finish = string.Format("{0:HH:mm:ss:ff tt}", DateTime.Now);

            //i wanted to test how much time does this take
            Console.WriteLine($"start {start}, finished {finish}");
        }
    }
}
