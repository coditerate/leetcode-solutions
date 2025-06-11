namespace LeetCode._0001_TwoSum;

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        for (var i = 0; i <= nums.Length - 1; i++)
//        {
//            for (var j = i+1; j <= nums.Length - 1; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    return [i, j];
//                }
//            }
//        }

//        return [];
//    }
//}


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (map.TryGetValue(complement, out var value))
            {
                return [value, i];
            }

            // Only add if not already in the map to avoid overwriting earlier index
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return [];
    }
}
