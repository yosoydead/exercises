using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputToBeNumbersVerify;

namespace TaxCalculator
{
    class Program
    {
        //custom class to check if the input is a number
        static Verify vfNumer = new Verify();
        const float tax = 5.5F;

        //ask for input and verify it
        static string input()
        {
            var l = Console.ReadLine();
            while (vfNumer.verify(l) == false)
            {
                l = Console.ReadLine();
            }
            return l;
        }

        //convert the input into an int
        static int transformToInt(string x)
        {
            int result = Int32.Parse(x);
            return result;
        }
        
        static void Main(string[] args)
        {
            int amount;
            float total;
            Console.Write("What is the order amount? ");
            amount = transformToInt(input());
            total = amount + (amount * (tax / 100));
            Console.WriteLine("What is the state? ");
            var state = Console.ReadLine();
            if (state == "WI" || state == "wi" || state == "Wi")
            {
                Console.WriteLine($"Subtotal is {amount:c}, tax is {(tax/100):c}, total is {total:c}");
            }
            else
            {
                Console.WriteLine($"Total is {amount}");
            }
        }
    }
}
