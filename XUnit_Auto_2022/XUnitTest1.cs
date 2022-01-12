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

        [Fact]
        public void Test1()
        {
            testOutputHelper.WriteLine("My test");
            Calculator c = new Calculator(50, 100, '-');
            Assert.Equal(-50, c.Compute());
        }

    }
}
