using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scramblies
{
    class Program
    {
        //just a simple check to see if the string contains other characters other than letters
        static bool ensure (List<char> list)
        {
            bool? x = null;
            foreach (var item in list)
            {
                if (char.IsDigit(item) || char.IsPunctuation(item) || char.IsWhiteSpace(item) || char.IsSymbol(item) || char.IsSeparator(item))
                {
                    x = false;
                    break;
                }
            }
            return x ?? true;
        }

        static bool scramble(string a, string b)
        {

            bool? result = null;
            string word = "";

            //transform the scrambled letters into a list of characters
            List<char> list = a.ToCharArray().ToList();

            //return false if the list contains anything other than letters
            if (ensure(list) == false)
            {
                result = false;
            }
            else
            {
                //check to see if you can form a word with all the scrambled letters
                foreach (var item in b)
                {
                    if (list.Contains(item))
                    {
                        word += item;
                        list.Remove(item);
                    }
                }
            }

            //if the word made by you is == to the b param, return true
            return result ?? (word == b);
        }

        static void Main(string[] args)
        {
            string a = "rkqodlw";
            string b = "world";
            Console.WriteLine(Scramble(a,b));
        }
    }
}
