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
                var result = kata.BubbleSortOnce(new int[] { 3, 4, 5 });
            // Assert
                Assert.Equal(3, result.Length);
        }
    }
}
