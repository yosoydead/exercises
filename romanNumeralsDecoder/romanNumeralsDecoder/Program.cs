using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanNumeralsDecoder
{
    class Program
    {
        static Dictionary<char, int> dict = new Dictionary<char, int>() {
                { 'I', 1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}

        };
        static int decoder(string s) {
            int result = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                //if this is the last digit, just add it to the total so I don't lose it
                if (i == s.Length - 1)
                {
                    result += dict[s[i]];
                    break;
                }
                //ex: 4 is displayed as IV. this means that if the first number
                //is less than the second, you subtract the first number from the total and then
                //add the last number. IE 0 - 1 = -1 => -1 + 5 = 4
                //took me a while to see this
                if (dict[s[i]] < dict[s[i+1]])
                {
                    result -= dict[s[i]];
                }
                //if it is not smaller than the next digit, just add it to the total
                else
                {
                    result += dict[s[i]];
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string s = "MCMXC";
            //string s = "MMVIII";
            //string s = "MDCLXVI";
            Console.WriteLine(decoder(s));
            //returns in order of the strings: 1990, 2008, 1666
        }
    }
}
