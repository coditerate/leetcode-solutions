using LeetCode._0028_FindIndexOfFirstOccurrenceInString;
using Shouldly;

namespace LeetCode.Tests;

public class _0028_FindIndexOfFirstOccurrenceInStringTest
{
    [Fact]
    public void FindIndexOfFirstOccurrenceInStringTest()
    {
        // Arrange
        var solution = new Solution();

        const string hayStack1 = "sadbutsad";
        const string needle1 = "sad";

        const string hayStack2 = "leetcode";
        const string needle2 = "leeto";

        const string hayStack3 = "a";
        const string needle3 = "a";

        const string hayStack4 = "hello";
        const string needle4 = "ll";

        // Act
        var result1 = solution.StrStr(hayStack1, needle1);
        var result2 = solution.StrStr(hayStack2, needle2);
        var result3 = solution.StrStr(hayStack3, needle3);
        var result4 = solution.StrStr(hayStack4, needle4);

        // Assert
        result1.ShouldBe(0);
        result2.ShouldBe(-1);
        result3.ShouldBe(0);
        result4.ShouldBe(2);
    }
}
