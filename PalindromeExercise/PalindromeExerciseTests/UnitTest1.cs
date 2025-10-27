using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        // For example [InlineData(“racecar”, true)]
        [InlineData("dad", true)]
        [InlineData("mom", true)]
        [InlineData("bob", true)]
        [InlineData("keyfob", false)]
        [InlineData("boat", false)]
        [InlineData("red", false)]
        [InlineData("star", false)]
        [InlineData("Racecar", true)]
        public void Test1(string text, bool expected)
        {
            // Arrange
            var wordtest = new WordSmith();
            
            // Act
            var actual = wordtest.IsAPalindrome(text);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
