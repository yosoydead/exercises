using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputToBeNumbersVerify;

namespace LegalDrivingAge
{
    class Program
    {
        //verify is a custom class that looks through the input
        //and return false if the input is not an int
        static Verify vf = new Verify();

        //ask the user for input
        //at the same time, use the custom class to validate the input
        static string input()
        {
            var l = Console.ReadLine();
            while (vf.verify(l) == false)
            {
                l = Console.ReadLine();
            }
            return l;
        }

        //convert the string input into int
        static int toInt(string x)
        {
            return Int32.Parse(x);
        }

        static void Main(string[] args)
        {
            //a dict containing some regions and the legal age for driving
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("europe", 18);
            dict.Add("usa", 16);
            dict.Add("asia", 18);
            dict.Add("south america", 18);

            Console.WriteLine("What age are you ?");
            int age = toInt(input());
            Console.WriteLine("Region? ");
            string l = Console.ReadLine();
            while (dict.ContainsKey(l) == false)
            {
                Console.WriteLine("There is no such region.");
                l = Console.ReadLine();
            }

            if (dict.ContainsKey(l) && dict.ContainsValue(age))
            {
                Console.WriteLine("You're old enough");
            }
            else
            {
                Console.WriteLine("No old enough");
            }

        }
    }
}
