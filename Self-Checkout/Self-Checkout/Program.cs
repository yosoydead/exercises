using InputToBeNumbersVerify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Checkout
{
    class Program
    {
        const double taxRate = 0.055;

        //custom class made to check if the input is a number or not
        static Verify vf = new Verify();

        //convert the string input to a double
        static double transform(string x)
        {
            double result = double.Parse(x);
            return result;
        }

        //ask for user input
        static string input()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var l = Console.ReadLine();
            while (vf.verify(l) == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                l = Console.ReadLine();
            }
            Console.ResetColor();
            return l;
        }
        static void Main(string[] args)
        {
            double price, total = 0F , subtotal = 0F, tax, amount;
            int i = 0;
            int contor = 0;
            Console.WriteLine("Simple Checkout.");
            while (true)
            {
                Console.Write($"Enter the price for item {i+1}: ");
                price = transform(input());

                Console.Write($"Enter the quantity for item {i+1}: ");
                amount = transform(input());

                subtotal = subtotal + (price * amount);
                tax = Math.Round(subtotal*taxRate, 2);
                total = Math.Round(subtotal + tax, 2);
                Console.WriteLine($"Current subtotal: {string.Format("{0:F2}", subtotal)}\nCurrent tax: {string.Format("{0:F2}", tax)}\nCurrent total: {string.Format("{0:F2}", total)}");
                i++;
                contor++;
                //once every three items, ask the user if he wants to add more items to the shopping list
                if (contor == 3)
                {
                    Console.Write("Would you like to continue adding items ?");
                    var l = Console.ReadLine();
                    if (l == "yes")
                    {
                        //reset the counting variable so it asks again at another 3 items added
                        contor = 0;
                        continue;
                    }
                    else if(l == "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Once again. Current subtotal: {string.Format("{0:F2}", subtotal)}\nCurrent tax: {string.Format("{0:F2}", tax)}\nCurrent total: {string.Format("{0:F2}", total)}");
                        Console.ResetColor();
                        break;
                    }
                }
            }

            subtotal = Math.Round(subtotal,2);
            tax = Math.Round(subtotal * taxRate, 2);
            total = Math.Round(subtotal + tax, 2);
            Console.WriteLine($"Subtotal: {subtotal:c}, tax: {tax:c}, total: {total:c}");
        }
    }
}
