using LeetCode._0001_TwoSum;
using Shouldly;

namespace LeetCode.Tests;

public class _0001_TwoSumTest
{
    [Fact]
    public void TwoSumTest()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result1 = solution.TwoSum([2, 7, 11, 15], 9);
        var result2 = solution.TwoSum([3, 2, 4], 6);
        var result3 = solution.TwoSum([3, 3], 6);

        // Assert
        result1.ShouldBe([0, 1]);
        result2.ShouldBe([1, 2]);
        result3.ShouldBe([0, 1]);
    }
}
