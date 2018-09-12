using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace word_a10n_Abbreviation
{
    class Program
    {
        static string transform (string test)
        {
            string res = "";
            int count = 1;

            //if the length of the string is 4 or bigger, calculate how many letters
            //are inbetween the first and the last one
            if (test.Length >= 4)
            {
                for (int i = 1; i < test.Length - 2; i++)
                {
                    count++;
                }
                res = test[0] + count.ToString() + test[test.Length - 1];
            }
            //if the length if less than 4, return the input string
            else
            {
                return test;
            }

            return res;
        }
        static void Main(string[] args)
        {
            //string s = "my. dog, isn't feeling very well.";
            //string s = "elephant-rides are really fun!";
            string s = "internationalization";

            string word = "";
            List<object> l = new List<object>();

            //add each word without any punctuations or numbers into a list
            for (int i = 0; i < s.Length; i++)
            {
                //if the current character is a letter, append it to the word variable
                if (char.IsLetter(s[i]))
                {
                    word += s[i];
                }
                else
                {
                    l.Add(word);
                    l.Add(s[i]);
                    word = "";
                }
            }


            //add the last word so it doesn't get lost
            l.Add(word);
            string sent = "";

            //transform every word
            foreach (var item in l)
            {
                if (item.ToString().Length > 3)
                {
                    sent += transform(item.ToString());
                }
                else
                {
                    sent += item.ToString();
                }
            }

            Console.WriteLine(sent);
        }
    }
}
