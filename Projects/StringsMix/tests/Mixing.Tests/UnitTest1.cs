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

        [Theory]
        [InlineData("ccccaaaddd", "aaaccccddd")]
        public void Should_Format_String(string input, string expected)
        {
            var actual = _mixer.FormatInput(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aabb", "aaabbc", "2:aaa/=:bb")]
        public void Should_Format_String2(string s1, string s2, string expected)
        {
            var actual = _mixer.FormatCombine(s1, s2);

            Assert.Equal(expected, actual);
        }
    }
}
