using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData("https://example.foobar.com", true)]
        [InlineData("http://example.foobar.com", false)]
        public void IsSecureReturnsExpected (string str, bool excpected)
        {
            // Arrange
            var uri = new Uri(str);

            // Act
            var actual = uri.IsSecure();
            
            // Assert
            Assert.Equal(excpected, actual);
        }

        [Theory]
        [InlineData("splits the string at a delimiter determined by a regular expression instead of a set of characters. The string is split as many times as possible. If no delimiter is found, the return value contains one element whose value is the original", 42)]
        [InlineData("abc 123 def", 2)]
        [InlineData("abc123 def", 2)]
        [InlineData("abc123def", 2)]
        public void WordcountReturstExpected (string str, int expected)
        {
            // Act
            var actual = str.WordCount();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
