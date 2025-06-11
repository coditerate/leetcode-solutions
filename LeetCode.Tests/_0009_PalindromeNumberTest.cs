using LeetCode._0009_PalindromeNumber;
using Shouldly;

namespace LeetCode.Tests;

public class _0009_PalindromeNumberTest
{
    [Fact]
    public void IsPalindromeTest()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result1 = solution.IsPalindrome(121);
        var result2 = solution.IsPalindrome(-121);
        var result3 = solution.IsPalindrome(10);

        // Assert
        result1.ShouldBe(true);
        result2.ShouldBe(false);
        result3.ShouldBe(false);
    }
}
