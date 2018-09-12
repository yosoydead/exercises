using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        /// <summary>
        /// 1. afisati elementele matricei -da
        /// 2. elem unei linii ???
        /// 3. elem unei coloane ???
        /// 4. elem de pe diagonala principala -da
        /// 5. elem de pe diagonala secundara -da
        /// 6. elem de sub diagonala principala -da
        /// 7. elem deasupra diag pp -da
        /// 8. elem de sub diag sec -da
        /// 9. elem deasupra diag sec -da
        /// 10. elem cadranului N
        /// 11. elem cadran V
        /// 12. elem cadran S
        /// 13. elem cadran E
        /// </summary>
        /// <param name="args"></param>
        /// 
        static int[,] a = new int[,]{
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25}
            };
        static int bound = a.GetUpperBound(0);
        
        static void elemente()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void diagPP ()
        {
            int s = 0;
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound ; j++)
                {
                    if (i == j)
                    {
                        Console.Write(a[i, j] + " ");
                        s = s + a[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Suma elementelor = {s}");
        }
        static void subPP()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (j < i)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void deasupraPP()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (i < j)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void diagSec()
        {
            int s = 0;
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (i == bound - j)
                    {
                        Console.Write(a[i, j] + " ");
                        s = s + a[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Suma elementelor = {s}");
        }
        static void subSec()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (j > bound -i)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void deasupraSec()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                {
                    if (j < bound - i)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void cadranN()
        {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0+i; j <= bound-i; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void cadranV() {
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0 + i; j <= bound - i; j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void cadranS ()
        {
            for (int i = bound/2 ; i <= bound; i++)
            {
                for (int j = bound -i; j <= i ; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void cadranE()
        {
            for (int i = bound/2; i <= bound; i++)
            {
                for (int j = bound -i; j <= i; j++)
                {
                    Console.Write(a[j,i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Elemente");
            elemente();
            Console.WriteLine();

            Console.WriteLine("Diagonala principala");
            diagPP();
            Console.WriteLine();

            Console.WriteLine("Sub diag PP");
            subPP();
            Console.WriteLine();

            Console.WriteLine("Deasupra diag PP");
            deasupraPP();
            Console.WriteLine();

            Console.WriteLine("Diagonala secundara");
            diagSec();
            Console.WriteLine();

            Console.WriteLine("Deasupra diag sec");
            deasupraSec();
            Console.WriteLine();

            Console.WriteLine("Sub diag sec");
            subSec();
            Console.WriteLine();

            Console.WriteLine("Cadran N");
            cadranN();
            Console.WriteLine();

            Console.WriteLine("Cadran V");
            cadranV();
            Console.WriteLine();

            Console.WriteLine("Cadran S");
            cadranS();
            Console.WriteLine();

            Console.WriteLine("Cadran E");
            cadranE();
            Console.WriteLine();

        }
    }
}
