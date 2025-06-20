namespace LeetCode._0026_RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var i = 0;

        for (var j = 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j]) continue;

            i++;
            nums[i] = nums[j];
        }

        return i + 1;
    }
}
