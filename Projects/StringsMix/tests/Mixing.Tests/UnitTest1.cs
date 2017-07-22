using System;
using Xunit;
using Mixing;
using System.Linq;

namespace Mixing.Tests
{
    public class MixingTests
    {
        private readonly Mixer _mixer;
        public MixingTests()
        {
            _mixer = new Mixer();
        }

        [Theory]
        [InlineData("aa", 'a', 2)]
        [InlineData("asd", 's', 1)]
        [InlineData("asd asd asd dsa dsa", 'a', 5)]
        public void ShouldReturn_RightCount_OfSpecificCharacter(string input, char filter, int expected)
        {
            var actual = _mixer.CharCounter(input, filter);

            Assert.Equal(expected, actual);
        }
    }
}
