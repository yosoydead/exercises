using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutations_my_way_
{
    public class Verify : IVerify
    {
        //this function tells me if the index is at the end of the array or not
        public bool isSolution(int[] array, int index)
        {
            return index == array.Length - 1;
        }

        //this function tells me if the value at the specified index in the array
        //can be found at other indexes too
        public bool isValid(int[] array, int index)
        {
            //save the value at the specified index
            int last = array[index];
            for (int i = 0; i < index; i++)
            {
                //if the item from the current index is == to the saved index, it means
                //that the solution is not valid because the indexes have to be unique
                if (array[i] == last)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
