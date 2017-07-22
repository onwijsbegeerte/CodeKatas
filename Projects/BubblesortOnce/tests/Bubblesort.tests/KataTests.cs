using System;
using Xunit;
using Bubblesort;

namespace Bubblesort.tests
{
    public class KataTests
    {
        private readonly Kata _kata;

        public KataTests(){
            this._kata = new Kata();
        }

        [Fact]
        public void Dependencies_Should_Be_Hooked_Up()
        {
            // Act
            var actual = _kata.BubbleSortOnce(new int[] { 3, 4, 5 });
            // Assert
            Assert.Equal(3, actual.Length);
        }

        [Theory]
        [InlineData(new int[] { 7, 5}, new int[] { 5, 7 })]
        public void One_Step_Should_Return_Modified_arr(int[] input, int[] expected) 
        {
            // Example test case from description
            Assert.Equal(expected, _kata.BubbleSortOnce(input));
        }

        // [Fact]
        // public void ExampleTest()
        // {
        //     var kata = new Kata();
        //     // Example test case from description
        //     var expected = new int[] { 7, 5, 3, 1, 2, 4, 6, 8, 9 };
        //     var actual = new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 };
        //     Assert.Equal(expected, kata.BubbleSortOnce(actual));
        // }
    }
}
