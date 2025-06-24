namespace LeetCode._0027_RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 1) return nums[0] == val ? 0 : 1;

        var i = 0;

        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] == val) continue;
            nums[i] = nums[j];
            i++;
        }

        return i;
    }
}
