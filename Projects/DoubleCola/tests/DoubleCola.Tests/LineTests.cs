using System;
using Xunit;
using DoubleCola;

namespace DoubleCola.Tests
{
    public class LineTests
    {
        private readonly Line _line;
        public LineTests()
        {
            this._line = new Line();
        }
        [Fact]
        public void WhoIsNext_Should_Return_Name_WithOut_Doubleing()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        
            var expected = _line.WhoIsNext(names, 0);
            
            Assert.Equal(names[0], expected);
        }

        [Fact]
        public void WhoIsNext_Should_Return_Name_After_First_Rotation()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        
            var expected = _line.WhoIsNext(names, 1);
            
            Assert.Equal("Leonard", expected);
        }
    }
}
