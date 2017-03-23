using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ProjectEuler.UnitTests
{
    [TestFixture]
    public class ProgramTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Problem2()
        {
            const int upperLimit = 4000000;
            const int answer = 4613732;

            var result = Program.Problem2(upperLimit);

            Assert.That(result, Is.EqualTo(answer));
        }

        [Test]
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
    }
}
