using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consonantValue
{
    class Program
    {
        public static int solve(string s)
        {
            //this will be the returned result of the function
            int biggest = 0;

            //this is used only for comparisons and updated values
            var result = 0;

            //list of every vowel
            List<char> l = new List<char>{ 'a', 'e', 'i', 'o', 'u'};

            //iterate over every character in the string
            foreach (var item in s)
            {
                //get the numeric value of the current letter.
                //this would start with a == 1 and so on
                int current = item - 96;

                //if the current letter is a vowel
                if (l.Contains(item))
                {
                    //reset the value of result
                    result = 0;
                }
                //if the letter is a consonant
                else
                {
                    //update the value of result
                    result += current;

                    //if result is bigger than the final value
                    if (result > biggest)
                    {
                        //update the final value
                        biggest = result;
                    }
                }
            }

            return biggest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solve("catchphrase"));
        }
    }
}
