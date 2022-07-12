using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var digits = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var notOdd = new List<int>();
            var notEven = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var thingy in digits) //for each loop
            {
                if (thingy % 2 == 0)
                {
                    notOdd.Add(thingy);
                }
                else
                {
                    notEven.Add(thingy);
                }
            }

            //for (int i = 0; i < digits.Length; i++) //for loop
            //{
            //    if (digits[i] % 2 == 0)
            //    {
            //        notOdd.Add(digits[i]);
            //    }
            //    else
            //    {
            //        notEven.Add(digits[i]);
            //    }
            //}

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Evens");
            foreach(var thingy in notOdd)
            {
                Console.WriteLine(thingy);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Odds");
            foreach(var thingy in notEven)
            {
                Console.WriteLine(thingy);
            }
        }
    }
}
