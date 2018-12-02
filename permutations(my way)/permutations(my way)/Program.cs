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
        static int factorial(int[] array){
            int length = array.Length;
            int result = 1;

            for (int i = 1; i <= length; i++)
            {
                result *= i;
            }

            return result;
        }

        static string convert(int[] array, int[] solutii)
        {
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result += (array[solutii[i]] + " ");
            }

            return result;
        }

        //i also need a function that checks if the current solution is valid or not
        //up to the given index or not
        static bool validate(int[] array, int index)
        {
            //save the variable from the array at the given index
            int last = array[index];
            for (int i = 0; i < index; i++)
            {
                //if the item from a given index is == to the saved index, it means
                //that the solution is not valid because the indexes have to be unique
                if (array[i] == last)
                {
                    return false;
                }
            }

            //i return true if the loop doesnt find any duplicate item
            return true;

        }
        static void Main(string[] args)
        {
            string start = string.Format("{0:HH:mm:ss:ff tt}", DateTime.Now);
            //this will be the array that holds the values to be permuted
            int[] array = { 1,2,3,4,5,6,7,8,9,10};
            //char[] array = { 'a', 'b', 'c' };
            //i will also need an array that will hold the indexes of the items
            int[] solution = new int[array.Length];

            // how many permutations i have to do
            int permsToDo = factorial(array);

            //how many permutations ive done so far
            int currentNumOfPermutations = 0;

            int index = 1;

            while (currentNumOfPermutations != permsToDo)
            {
                //first, i check if the value at the current index is < the maximum index in the given array
                //ie if the length is 3, then the last index is 2
                if (solution[index] < array.Length-1)
                {
                    //if its less that the maximum index, i can increment the value of the current index
                    solution[index] += 1;
                }
                //if it is = or bigger, i need to reset the value at the index position to -1
                //because i need the index to go one more position ahead and increment, and go back one step,
                //ie decrement the index
                else
                {
                    solution[index] = -1;
                    index--;
                    //i use continue because if i get to this point, i know that the solution is not valid
                    continue;
                }

                bool isValid = validate(solution, index);

                if (isValid == true)
                {
                    //if the solution is valid, then i check if the index can go one position farther
                    if (index < array.Length-1)
                    {
                        index++;
                        //i use continue because i know if the index can go on one more position, then 
                        //the solution is not valid
                        continue;
                    }

                    //if the index cant go farther, i check if it is a solution
                    //if the index is at the last position in the array, it should be a solution
                    if (index == array.Length-1)
                    {
                        //increment the number of current solutions
                        currentNumOfPermutations += 1;

                        //print the indexes of the solutions
                        //Console.WriteLine($"indexes are {string.Join(" ", solution)}");
                        Console.WriteLine($"solution {currentNumOfPermutations} = {convert(array, solution)}");
                        //Thread.Sleep(30);
                        //Console.Clear();

                        //after i find a solution, i reset the value at the current index, and go back one step
                        solution[index] = -1;
                        
                        index--;
                    }
                }
            }
            string finish = string.Format("{0:HH:mm:ss:ff tt}", DateTime.Now);

            Console.WriteLine($"start {start}, finished {finish}");
        }
    }
}
