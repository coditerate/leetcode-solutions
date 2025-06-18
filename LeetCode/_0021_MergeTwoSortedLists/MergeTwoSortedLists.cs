namespace LeetCode._0021_MergeTwoSortedLists;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        if (list1.val >= list2.val)
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
        else
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
    }
}
