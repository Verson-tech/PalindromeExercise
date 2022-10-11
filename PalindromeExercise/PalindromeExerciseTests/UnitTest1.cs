using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void Test1(string strName, bool expected)
        {
            var wordSmith = new WordSmith();
            var actual = wordSmith.IsAPalindrome(strName);
            Assert.Equal(expected, actual);

        }
    }
}
