using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace aDisguisedSequence
{
    class Program
    {
        static BigInteger a(int n) {
            BigInteger u0 = 1;
            BigInteger u1 = 2;

            BigInteger u2 = (6 * u0 * u1) / (5 * u0 - u1);

            for (int i = 3; i <= n; i++)
            {
                u0 = u1;
                u1 = u2;
                u2 = (6 * u0 * u1) / (5 * u0 - u1);
            }

            return u2;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Math.Pow(2, 17));
            Console.WriteLine(a(17));

        }
    }
}
