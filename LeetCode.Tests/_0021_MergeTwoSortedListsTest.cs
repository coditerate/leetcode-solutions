using LeetCode._0021_MergeTwoSortedLists;
using Shouldly;

namespace LeetCode.Tests;

public class _0021_MergeTwoSortedListsTest
{
    [Fact]
    public void MergeTwoSortedListsTest()
    {
        // Arrange
        var solution = new Solution();

        var list1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
        var expected1 = new[] { 1, 1, 2, 3, 4, 4 };

        ListNode list3 = null;
        ListNode list4 = null;
        var expected2 = new int[] { };

        ListNode list5 = null;
        var list6 = new ListNode(0, null);
        var expected3 = new[] { 0 };


        // Act
        var result1 = solution.MergeTwoLists(list1, list2);
        var result2 = solution.MergeTwoLists(list3, list4);
        var result3 = solution.MergeTwoLists(list5, list6);

        // Assert
        ToArray(result1).ShouldBe(expected1);
        ToArray(result2).ShouldBe(expected2);
        ToArray(result3).ShouldBe(expected3);
    }

    private int[] ToArray(ListNode node)
    {
        var result = new List<int>();
        while (node != null)
        {
            result.Add(node.val);
            node = node.next;
        }
        return result.ToArray();
    }
}
