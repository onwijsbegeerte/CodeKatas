using System;
using Xunit;
using DoubleCola;

namespace DoubleCola.Tests
{
    public class LineTests
    {
        private readonly Line _line;
        private readonly string[] names;
        public LineTests()
        {
            this._line = new Line();
            names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        }
        // [Fact]
        // public void WhoIsNext_Should_Return_Name_WithOut_Doubleing()
        // {

        //     var actually = _line.WhoIsNext(names, 0);

        //     Assert.Equal(names[0], actually);
        // }

        [Theory]
        [InlineData(1, "Sheldon")]
        [InlineData(2, "Leonard")]
        [InlineData(3, "Penny")]
        [InlineData(4, "Rajesh")]
        [InlineData(5, "Howard")]
        public void WhoIsNext_Should_Return_Name_After_First_Rotation(long n, string expected)
        {
            var actually = _line.WhoIsNext(names, n);

            Assert.Equal(expected, actually);
        }

        [Theory]
        [InlineData(6, "Sheldon")]
        [InlineData(7, "Sheldon")]
        [InlineData(8, "Leonard")]
        [InlineData(9, "Leonard")]
        [InlineData(52, "Penny")]
        // //     //[InlineData(1000, "Penny")]
        // //     // [InlineData(7230702951, "Leonard")]
        public void WhoIsNext_Should_Return_Name_For_N(long n, string expected)
        {
            var actually = _line.WhoIsNext(names, n);

            Assert.Equal(expected, actually);
        }
    }
}
