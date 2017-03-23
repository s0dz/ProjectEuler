using NUnit.Framework;

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
        public void Problem3()
        {
            var number = 13195;

            ProjectEuler.Program.Problem3(number);
        }
    }
}
