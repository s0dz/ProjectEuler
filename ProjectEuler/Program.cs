﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Application is running.");

            log.Info("problem1: " + Problem1());
            log.Info("problem2: " + Problem2(4000000));
            log.Info("problem3: " + Problem3(600851475143));

            // Console.Read();
        }

        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.
        public static int Problem1()
        {
            var sum = 0;

            var i = 1;
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
        
        // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        public static int Problem2(int upperLimit)
        {
            var sum = 2;

            var prev1 = 1;
            var prev2 = 2;

            var x = 0;

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

        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?
        public static List<int> Problem3(long number)
        {
            var remaining = number;
            var factor = 2;
            var primeFactors = new List<int>();

            while (remaining > 0)
            {
                if((remaining % factor) == 0)
                {
                    primeFactors.Add(factor);
                    remaining -= factor;
                }
                factor++;
            }

            return primeFactors;
        }

        public static List<int> Problem4(int numberOfDigits)
        {
            // lol? // Mutation
            numberOfDigits = Int32.Parse(String.Concat(Enumerable.Repeat("9", numberOfDigits)));
            var answer = new List<int>{0,0};
            
            for (var number1 = 1; number1 < numberOfDigits; number1++)
            {
                for (var number2 = 1; number2 < numberOfDigits; number2++)
                {
                    var product = number1 * number2;
                    if (CheckForPalindrome(product))
                    {
                        var temp = answer[0] * answer[1];
                        if (number1 * number2 > temp)
                        {
                            answer = new List<int>
                            {
                                number1,
                                number2
                            };
                        }
                    }
                }
            }

            return answer;
        }

        private static bool CheckForPalindrome(int palindrome)
        {
            /*if (palindrome)*/
            var palindromString = palindrome.ToString();
            if (palindromString.Length < 4 ) return false;

            var part1 = palindromString.Substring(0, 2);
            var part2 = palindromString.Substring(2, 2);

            var charArray = part2.ToCharArray();
            Array.Reverse(charArray); // Mutation
            part2 = new string(charArray);

            return (part1 == part2);
        }
    }
}
