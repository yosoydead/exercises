using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutations_my_way_
{
    //just an interface that can be used to create other classes with different
    //properties and ways to validate and display/save all the permutations
    public interface IVerify
    {
        bool isValid(int[] array, int index);
        bool isSolution(int[] array, int index);
    }
}
