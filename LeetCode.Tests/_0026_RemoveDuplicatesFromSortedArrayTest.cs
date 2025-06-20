using LeetCode._0026_RemoveDuplicatesFromSortedArray;
using Shouldly;

namespace LeetCode.Tests;

public class _0026_RemoveDuplicatesFromSortedArrayTest
{
    [Fact]
    public void RemoveDuplicatesFromSortedArrayTest()
    {
        // Arrange
        var solution = new Solution();

        var input1 = new[] { 1, 1, 2 };
        var expectedResult1 = new[] { 1, 2 };
        const int expectedLength1 = 2;


        var input2 = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        var expectedResult2 = new[] { 0, 1, 2, 3, 4 };
        const int expectedLength2 = 5;

        // Act
        var result1 = solution.RemoveDuplicates(input1);
        var result2 = solution.RemoveDuplicates(input2);

        // Assert
        result1.ShouldBe(expectedLength1);

        for (var i = 0; i < expectedLength1; i++)
        {
            input1[i].ShouldBe(expectedResult1[i]);
        }

        result2.ShouldBe(expectedLength2);

        for (var i = 0; i < expectedLength2; i++)
        {
            input2[i].ShouldBe(expectedResult2[i]);
        }
    }
}
