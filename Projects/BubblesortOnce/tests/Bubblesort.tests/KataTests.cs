using System;
using Xunit;
using Bubblesort;

namespace Bubblesort.tests
{
    public class KataTests
    {
        [Fact]
        public void Dependencies_Should_Be_Hooked_Up()
        {
            // Arrange
            var kata = new Kata();
            // Act
            var actual = kata.BubbleSortOnce(new int[] { 3, 4, 5 });
            // Assert
            Assert.Equal(3, actual.Length);
        }

        [Fact]
        public void One_Step_Should_Return_Modified_arr()
        {
            var kata = new Kata();
            // Example test case from description
            var input = new int[] { 7, 5};
       
            var expected = new int[] { 5, 7 };

            Assert.Equal(expected, kata.BubbleSortOnce(input));
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
