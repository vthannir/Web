using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = 4;
            var x = 16;

            Assert.Equal(4, SquareRoot(16));

        }

        [Theory]
        [InlineData(25, 5)]
        [InlineData(0, 0)]

        public void Test2(int test, int a) => Assert.Equal(a,SquareRoot(test));

        double SquareRoot(int a )
        {
            return Math.Sqrt(a);
        }
    }
}
