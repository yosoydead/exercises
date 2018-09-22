using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void swap(ref char a, ref char b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        static string reverse(string s)
        {
            var a = s.ToCharArray();
            for (int i = 0; i < s.Length/2; i++)
            {
                swap(ref a[i], ref a[a.Length-1-i]);
            }

            return new string(a);
        }
        static bool palindrom(string s1, string s2)
        {
            return s1 == s2;
        }

        static void Main(string[] args)
        {
            string a = "abba";
            string b = "bogdan";

            Console.WriteLine(palindrom(b, reverse(b)));
        }
    }
}
