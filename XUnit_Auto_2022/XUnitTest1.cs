using NUnit_Auto_2022;
using System;
using Xunit;
using Xunit.Abstractions;

namespace XUnit_Auto_2022
{
    public class XUnitTest1 : IDisposable
    {

        private readonly ITestOutputHelper testOutputHelper;
        public XUnitTest1(ITestOutputHelper testOutputHelper)
        {
            Console.WriteLine("Setup every test");
            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup line!");
        }

        public void Dispose()
        {
            testOutputHelper.WriteLine("TearDown");
        }
        //Fact is for test without parameteres, Theory is for tests wit parameters

        [Theory]
        [InlineData(50, 100, '-', -50)]
        [InlineData(50, -100, '-', 150)]
        public void Test1(double a, double b, char op, double res)
        {
            testOutputHelper.WriteLine("My test");
            Calculator c = new Calculator(a, b, '-');
            Assert.Equal(res, c.Compute());
        }

    }
}
