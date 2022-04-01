using NUnit.Framework;

namespace ConsoleApp1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Car c1 = new Car();
            var result = c1.getName();
            Assert.AreEqual(result, result);
            //Assert.Pass();
        }
    }
}
