﻿using System;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.UnitTests
{
    [TestFixture]
    public class ProgramTests
    {
        //private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [SetUp]
        public void SetUp()
        {
            //Log.Info("Tests are running.");
        }

        [Test]
        public void Problem2()
        {
            const int upperLimit = 4000000;
            const int answer = 4613732;

            var result = Program.Problem2(upperLimit);

            Assert.That(result, Is.EqualTo(answer));
        }

        //[Test]
        public void Problem3()
        {
            var number = 13195;

            var result = Program.Problem3(number);
            var total = 0;

            foreach (var primeNumber in result)
            {
                total *= primeNumber;
            }

            Assert.That(total, Is.EqualTo(number));
        }

        [TestCase(2)]
        [TestCase(3)]
        public void Problem4(int numberOfDigits)
        {
            var palindrome = 9009;
            var number1 = 91;
            var number2 = 99;

            var palindromString = palindrome.ToString();
            var part1 = palindromString.Substring(0, 2);
            var part2 = palindromString.Substring(2, 2);

            var charArray = part2.ToCharArray();
            Array.Reverse(charArray);

            Assert.That(part1, Is.EqualTo(charArray));

            var numbers = Program.Problem4(numberOfDigits);
            var answer = numbers.Aggregate((accumulation, value) => accumulation * value);
            // log answer
        }

        [Test]
        public void Problem5()
        {
            var lowerLimit = 1;
            var upperLimit = 10;
            var answer = 2520;

            var result = Program.Problem5(lowerLimit, upperLimit);

            Assert.That(result, Is.EqualTo(answer));
        }
    }
}
