using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(j >= 6-1-i)
                        Console.Write("#");
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            
        }


    }
}
