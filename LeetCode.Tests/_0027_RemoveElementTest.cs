using LeetCode._0027_RemoveElement;
using Shouldly;

namespace LeetCode.Tests;

public class _0027_RemoveElementTest
{
    [Fact]
    public void RemoveElementTest()
    {
        // Arrange
        var solution = new Solution();

        var input1Nums = new[] { 3, 2, 2, 3 };
        const int input1Val = 3;
        var expectedResult1 = new[] { 2, 2 };
        const int expectedLength1 = 2;


        var input2Nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        const int input2Val = 2;
        var expectedResult2 = new[] { 0, 1, 3, 0, 4 };
        const int expectedLength2 = 5;

        // Act
        var result1 = solution.RemoveElement(input1Nums, input1Val);
        var result2 = solution.RemoveElement(input2Nums, input2Val);

        // Assert
        result1.ShouldBe(expectedLength1);

        for (var i = 0; i < expectedLength1; i++)
        {
            input1Nums[i].ShouldBe(expectedResult1[i]);
        }

        result2.ShouldBe(expectedLength2);

        for (var i = 0; i < expectedLength2; i++)
        {
            input2Nums[i].ShouldBe(expectedResult2[i]);
        }
    }
}
