using LeetCode._0020_ValidParantheses;
using Shouldly;

namespace LeetCode.Tests;

public class _0020_ValidParanthesesTest
{
    [Fact]
    public void ValidParanthesesTest()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result1 = solution.IsValid("()");
        var result2 = solution.IsValid("()[]{}");
        var result3 = solution.IsValid("(]");
        var result4 = solution.IsValid("([])");

        // Assert
        result1.ShouldBe(true);
        result2.ShouldBe(true);
        result3.ShouldBe(false);
        result4.ShouldBe(true);
    }
}
