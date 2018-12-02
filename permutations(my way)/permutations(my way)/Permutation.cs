using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutations_my_way_
{
    
    public class Permutation
    {
        //a private member that holds the solutions
        private int[] _solutions;

        //private member that holds the values of the parameter from the constructor
        private int[] _values;

        //private member that holds the number of current permutations done
        private int _currentNumOfPermutations;

        //private member that holds the number of the permutations that need to be done
        private int _totalNumOfPermutations;

        //function that performs n factorial
        private int factorial(int[] array)
        {
            int result = 1;
            int length = array.Length;

            for (int i = 1; i <= length; i++)
            {
                result *= i;
            }

            return result;
        }

        //function that is going to display the actual values, not the indexes
        private string valuesToString(int[] array)
        {
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result += (_values[_solutions[i]] + " ");
            }

            return result;
        }

        //constructor will take as a parameter the array that will be permuted
        public Permutation(int[] array)
        {
            //initialize all the private members
            _values = array;

            _solutions = new int[_values.Length];

            _currentNumOfPermutations = 0;

            _totalNumOfPermutations = factorial(_values);
        }

        //the function that does the permutations
        //i use what is called dependency injection, meaning i dont need to know/care what class
        //would use it or how many
        public void GeneratePermutation(IVerify verify)
        {
            int index = 1;

            while (_currentNumOfPermutations != _totalNumOfPermutations)
            {
                //first, i check if the value at the current index is < the maximum index in the given array
                //ie if the length is 3, then the last index is 2
                if (_solutions[index] < _values.Length - 1)
                {
                    //if its less that the maximum index, i can increment the value of the current index
                    _solutions[index] += 1;
                }
                //if it is = or bigger, i need to reset the value at the index position and go back one step,
                //ie decrement the index
                else
                {
                    //i reset the value to -1 because i want the loop to increment the value from -1 to 0
                    //and then check to see if the solution is valid or not 
                    //if i reset it to 0, then it will increment it to the max value, then go back, and so on,
                    //until it reaches the first index in the array and it misses many solutions and gives index
                    //out of range
                    _solutions[index] = -1;
                    index--;
                    //i use continue because if i get to this point, i know that the solution is not valid
                    continue;
                }

                bool validate = verify.isValid(_solutions, index);
                if (validate == true)
                {
                    //if the solution is valid, then i check if the index can go one position farther
                    if (index < _values.Length-1)
                    {
                        index++;
                        //i use continue because i know if the index can go on one more position, then 
                        //the solution is not valid
                        continue;
                    }
                    //if the index cant go farther, i check if it is a solution
                    //if the index is at the last position in the array, it should be a solution
                    if (verify.isSolution(_values, index))
                    {
                        //increment the number of current solutions
                        _currentNumOfPermutations += 1;

                        //print the indexes of the solutions
                        //Console.WriteLine($"indexes are {string.Join(" ", solution)}");
                        Console.WriteLine($"solution {_currentNumOfPermutations} = {valuesToString(_solutions)}");
                        //Thread.Sleep(30);
                        //Console.Clear();

                        //after i find a solution, i reset the value at the current index, and go back one step
                        _solutions[index] = -1;

                        index--;
                    }
                }
            }
        }
    }
}
