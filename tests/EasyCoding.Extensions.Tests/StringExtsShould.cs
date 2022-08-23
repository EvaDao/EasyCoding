using Shouldly;
using Xunit;

namespace EasyCoding.Tests
{
    public class StringExtsShould
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("   ", false)]
        [InlineData(" s  ", false)]
        [InlineData("any", false)]
        public void IsNullOrEmpty_Tests(string value, bool expected)
        {
            value.IsNullOrEmpty().ShouldBe(expected);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("   ", true)]
        [InlineData(" s  ", false)]
        [InlineData("any", false)]
        public void IsNullOrWhiteSpace_Tests(string value, bool expected)
        {
            value.IsNullOrWhiteSpace().ShouldBe(expected);
        }

        [Theory]
        [InlineData(null, 0, 10, null)]
        [InlineData("", 0, 10, "")]
        [InlineData("", 11, 10, "")]
        [InlineData("", 4, 10, "")]
        [InlineData(" ", 0, 10, " ")]
        [InlineData(" ", 6, 10, "")]
        [InlineData("1234567", 0, 10, "1234567")]
        [InlineData("1234567", 1, 10, "234567")]
        [InlineData("1234567", 10, 10, "")]
        public void SafeSubstring_Tests(string value, int startIndex, int length, string expected)
        {
            value.SafeSubstring(startIndex, length).ShouldBe(expected);
        }
    }
}
