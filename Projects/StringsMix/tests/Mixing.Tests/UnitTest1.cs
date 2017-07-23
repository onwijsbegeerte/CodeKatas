using System;
using Xunit;
using Mixing;
using System.Linq;
using System.Collections.Generic;

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

        [Fact]
        public void Shoud_Sort_Stuff()
        {
            var actual = new List<string>() { "2:bbbb", "1:aaaaaaa", "=:bb" };
            var exptected = new List<string>() { "1:aaaaaaa", "2:bbbb", "=:bb" };
            var result = _mixer.FormatResult(actual);

            Assert.Equal(exptected, result);
        }

        [Fact]
        public void Shoud_Sort_Symbols()
        {
            var actual = new List<string>() { "2:bbbb", "1:bbbb", "=:bbbb" };
            var exptected = new List<string>() { "1:bbbb", "2:bbbb", "=:bbbb" };
            var result = _mixer.FormatResult(actual);

            Assert.Equal(exptected, result);
        }

        [Fact]
        public void Shoud_Sort_SymbolsandChar()
        {
            var actual = new List<string>() { "2:cccc", "1:bbbb", "1:dddd", "=:qq" };
            var exptected = new List<string>() { "1:bbbb", "1:dddd", "2:cccc", "=:qq" };
            var result = _mixer.FormatResult(actual);

            Assert.Equal(exptected, result);
        }

        [Theory]
        [InlineData("aabb", "aaabbc", "2:aaa/=:bb")]
        [InlineData("aabb!@#!@#", "aaabbc@#$@#$333", "2:aaa/=:bb")]
        [InlineData("@#$//aabb!@#!@#////", "aaabbc@#$@#$333", "2:aaa/=:bb")]
        [InlineData("Are they here", "yes, they are here", "2:eeeee/2:yy/=:hh/=:rr")]
        [InlineData("looping is fun but dangerous", "less dangerous than coding", "1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg")]
        [InlineData(" In many languages", " there's a pair of functions", "1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt")]
        [InlineData("Lords of the Fallen", "gamekult", "1:ee/1:ll/1:oo")]
        [InlineData("codewars", "codewars", "")]
        [InlineData("A generation must confront the looming ", "codewarrs", "1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr")]
        public void Should_Format_String2(string s1, string s2, string expected)
        {
            var actual = _mixer.Mix(s1, s2);

            Assert.Equal(expected, actual);
        }
    }
}
