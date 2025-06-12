using LeetCode._0014_LongestCommonPrefix;
using Shouldly;

namespace LeetCode.Tests;

public class _0014_LongestCommonPrefixTest
{
    [Fact]
    public void LongestCommonPrefixTest()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result1 = solution.LongestCommonPrefix(["flower", "flow", "flight"]);
        var result2 = solution.LongestCommonPrefix(["dog", "racecar", "car"]);
        var result3 = solution.LongestCommonPrefix(["a"]);
        var result4 = solution.LongestCommonPrefix(["ab", "a"]);

        // Assert
        result1.ShouldBe("fl");
        result2.ShouldBe("");
        result3.ShouldBe("a");
        result4.ShouldBe("a");
    }
}
