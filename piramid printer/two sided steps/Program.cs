using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_sided_steps
{
    class Program
    {
        static void printPiramida(int n)
        {
            //n = numarul de randuri care trebuie printat
            //primul loop reprezinta doar randul care urmeaza sa fie printat
            //al 2lea reprezinta printatul randului in sine

            //pattern 
            /* *
                 #
                ###
               #####
              #######
             

            ultimul rand reprezinta totalul de # pe care trebuie sa il avem la dispozitie
            deci al2lea for trebuie sa mearga pana la (n*2) -1
            ex: n = 4 => i = 3 ultimul rand trebuie sa aiba 4*2 -1 = 7 caractere
            ex: n = 5 => i = 4 rand trebuie sa aiba 5*2-1 = 9 caractere
            etc etc

            ca sa printam # in ordinea in care trebuie, avem de verificat 
            daca j >= (n*2 -1)/2 -i si j <= (n*2-1)/2 +i

            ex: n = 4, i = 0; j = 0
            (n*2-1)/2 -i = (n*2-1)/2 -0 = 3 rotunjit 
            (n*2-1)/2 +i = (n*2-1)/2 +0 = 3 rotunjit 
            => j >= (n*2-1)/2 -i adica 0 >= 3 si j <= (n*2-1)/2 +i adica 0 <= 3 nu e adevarat 

            ex: n = 4, i = 0; j = 1
            (n*2-1)/2 -i = (n*2-1)/2 -0 = 3 rotunjit 
            (n*2-1)/2 +i = (n*2-1)/2 +0 = 3 rotunjit 
            => j >= (n*2-1)/2 -i adica 1 >= 3 si j <= (n*2-1)/2 +i adica 1 <= 3 nu e adevarat print " "

            ex: n = 4, i = 0; j = 3
            (n*2-1)/2 -i = (n*2-1)/2 -0 = 3 rotunjit 
            (n*2-1)/2 +i = (n*2-1)/2 +0 = 3 rotunjit 
            => j >= (n*2-1)/2 -i adica 3 >= 3 si j <= (n*2-1)/2 +i adica 3 <= 3 e adevarat print "#"

            ex: n = 4, i = 1; j = 0
            (n*2-1)/2 -i = (n*2-1)/2 -1 = 2 rotunjit 
            (n*2-1)/2 +i = (n*2-1)/2 +1 = 4 rotunjit 
            => j >= (n*2-1)/2 -i adica 0 >= 2 si j <= (n*2-1)/2 +i adica 0 <= 4 nu e adevarat  print " "

            ex: n = 4, i = 1; j = 2
            (n*2-1)/2 -i = (n*2-1)/2 -1 = 2 rotunjit 
            (n*2-1)/2 +i = (n*2-1)/2 +1 = 4 rotunjit 
            => j >= (n*2-1)/2 -i adica 2 >= 2 si j <= (n*2-1)/2 +i adica 2 <= 4 e adevarat  print "#"
            etc etc
             */
            int needed = (n * 2) - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < needed; j++)
                {
                    int min = (needed / 2) - i;
                    int max = (needed / 2) + i;

                    if (j >= min && j <= max)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < (n*2) -1; j++)
            //    {
            //        //Console.Write("#");
            //        //if (j >= ((n * 2) - 1) || j <= (((n * 2) - 1) / 2) - i)
            //        //    Console.Write("#");
            //        int a = ((n * 2) - 1) / 2 -i;
            //        int b = ((n * 2) - 1) / 2 + i;
            //        if (j >= ((n * 2) - 1)/2 -i && j <= ((n * 2) - 1) / 2 + i)
            //            Console.Write("#");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            printPiramida(n);
        }
    }
}
