using System;
using Xunit;
using DoubleCola;

namespace DoubleCola.Tests
{
    public class LineTests
    {
        [Fact]
        public void WhoIsNext_Should_Return_Name_WithOut_Doubleing()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            var line = new Line();
        
            var expected = line.WhoIsNext(names, 0);
            
            Assert.Equal(names[0], expected);
        }
    }
}
