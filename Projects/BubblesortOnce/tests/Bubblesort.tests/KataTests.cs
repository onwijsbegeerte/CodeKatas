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
            var actual = _kata.BubbleSortOnce(new int[] { 3, 4, 5 });
            Assert.Equal(3, actual.Length);
        }

        [Theory]
        [InlineData(new int[] { 7, 5 }, new int[] { 5, 7 })]
        [InlineData(new int[] { 7, 5 }, new int[] { 5, 7 })]
        [InlineData(new int[] { 7, 7 }, new int[] { 7, 7 })]
        public void One_Step_Should_Return_Modified_arr(int[] input, int[] expected) 
        {
            Assert.Equal(expected, _kata.BubbleSortOnce(input));
        }

        [Theory]
        [InlineData(new int[] { 7, 5, 1 }, new int[] { 5, 1, 7 })]
        [InlineData(new int[] { 7, 5, 1, 8 }, new int[] { 5, 1, 7, 8 })]
        [InlineData(new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 }, new int[] { 7, 5, 3, 1, 2, 4, 6, 8, 9 })]
        public void Multiple_Steps_Should_Return_Modified_arr(int[] input, int[] expected) 
        {
            Assert.Equal(expected, _kata.BubbleSortOnce(input));
        }
    }
}
