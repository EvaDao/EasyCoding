using Shouldly;
using Xunit;

namespace EasyCoding.Extensions.Tests
{
    public class EnumExtShould
    {
        [Theory]
        [InlineData(testEnum.first, 1)]
        [InlineData(testEnum.second, 2)]
        [InlineData(testEnum.notset, 0)]
        public void ToInt32_Tests(testEnum value, int expected)
        {
            value.ToInt32().ShouldBe(expected);
        }

        [Theory]
        [InlineData("first", testEnum.first)]
        [InlineData("second", testEnum.second)]
        [InlineData("notset", testEnum.notset)]
        [InlineData("anyssss", testEnum.notset)]
        public void SafeParse_Tests(string value, testEnum expected)
        {
            value.SafeParse<testEnum>().ShouldBe(expected);
        }

        public enum testEnum
        {
            notset = 0,
            first = 1,
            second = 2,
        }
    }
}
