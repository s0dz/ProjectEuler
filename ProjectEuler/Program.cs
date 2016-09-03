﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("problem1: " + problem1());
            Console.WriteLine("problem2: " + problem2());
            Console.WriteLine("problem3: " + problem3());

            Console.Read();
        }

        public static int problem1()
        {
            /*
             * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
             * Find the sum of all the multiples of 3 or 5 below 1000.
             */

            int sum = 0;

            int i = 1;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
                i++;
            }

            return sum;
        }

        public static int problem2()
        {
            /*
             * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
             * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
             * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
             */

            int sum = 2;

            int prev1 = 1;
            int prev2 = 2;

            int x = 0;

            while (x < 4000000)
            {
                x = prev1 + prev2;
                prev1 = prev2;
                prev2 = x;

                if (x % 2 == 0)
                {
                    sum += x;
                }
            }

            return sum;
        }

        public static int problem3()
        {
            int number = 13195;
            // 5, 7, 13 and 29

            throw new NotImplementedException();
        }
    }
}
