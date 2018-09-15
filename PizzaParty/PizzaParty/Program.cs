using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaParty
{
    class Program
    {
        //custom class to check if the input is a number
        static bool verify(string x)
        {
            if (x.Any(char.IsLetter) ||
                string.IsNullOrEmpty(x) ||
                string.IsNullOrWhiteSpace(x) ||
                x.Any(char.IsPunctuation) ||
                int.Parse(x) <= 0)
            {
                Console.WriteLine("Input must not be a letter, string, punctuation or whitespace.");
                return false;
            }
            return true;
        }

        static void pizzaSlicesToEveryone()
        {
            int people, pizzas, result;
            int slices = 8;
            float leftOvers;

            Console.Write("How many people are coming to the party? ");
            var ppl = Console.ReadLine();
            while (verify(ppl) == false)
            {
                ppl = Console.ReadLine();
            }

            Console.Write("How many pizzas do you have? ");
            var pieces = Console.ReadLine();
            while (verify(pieces) == false)
            {
                pieces = Console.ReadLine();
            }

            people = Convert.ToInt32(ppl);
            pizzas = int.Parse(pieces);
            result = (pizzas * slices) / people;
            leftOvers = (float)(pizzas * slices) % people;

            Console.WriteLine($"So there are {ppl} persons and {pieces} pizzas. That means {pizzas * slices} slices. Let us see.");

            if (result <= 1)
            {
                Console.WriteLine($"Each person gets {result} piece of pizza.");
            }
            else if (result >= 2)
            {
                Console.WriteLine($"Each person gets {result} pieces of pizza");
            }
            Console.WriteLine($"There are {leftOvers} leftover pieces.");
        }

        static void howManyFullPizzasYouNeed()
        {
            int slicesInPizza = 8;
            int people, slices;
            float fullPizzas;

            Console.Write("How many people are coming to the party? ");
            var ppl = Console.ReadLine();
            while (verify(ppl) == false)
            {
                ppl = Console.ReadLine();
            }

            Console.Write("How many slices of pizza does everybody want? ");
            var slice = Console.ReadLine();
            while (verify(slice) == false)
            {
                slice = Console.ReadLine();
            }

            people = int.Parse(ppl);
            slices = int.Parse(slice);

            fullPizzas = (float)(people + slices) / slicesInPizza;

            Console.WriteLine($"So {people} people are coming and all of you want a total of {slices} slices of pizza.");

            Console.WriteLine($"This means you will need {fullPizzas} pizzas.");
        }

        static void Main(string[] args)
        {
            pizzaSlicesToEveryone();
           // howManyFullPizzasYouNeed();
        }
    }
}
