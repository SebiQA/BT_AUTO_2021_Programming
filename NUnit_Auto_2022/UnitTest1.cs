using NUnit.Framework;
using System;

namespace NUnit_Auto_2022
{
    [TestFixture(15,35)]
    [TestFixture(25, 22)]
    public class Tests
    {
        int x;
        int y;

        [OneTimeSetUp]
        public void SetupOnce()
        {
            TestContext.Out.WriteLine("Stii ce ;), this method runs only once for all tests");
        }

        public Tests(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Run me at every test!");
        }

        [Test(Description ="Test2 with numbers")]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Console.WriteLine("First value is {0} second value is {1}", x, y);
        }

        [TestCase(69, 24, 199)]
        [TestCase(-100, -200, -333)]
        public void Test3(int a, int b, int c)
        {
            Console.WriteLine("the sum is {0}", a + b + c + x + y);
            //Assert.AreEqual(-550, a + b + c + x + y, 0, "the test failed");
            Assert.That(a, Is.InRange(100, 500));
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Let's do some cleanup for every test");
        }

        [OneTimeTearDown]
        public void GeneralCleanUp()
        {
            TestContext.Out.WriteLine("Is the final .. cleanup! :)");
        }

    }
}