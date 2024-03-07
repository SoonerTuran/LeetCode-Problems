public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        if (nums == null || nums.Length < 2)
        {
            return new int[] { -1, -1 };
        }
        int complement = -1;
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }

            numDict[nums[i]] = i;
        }

        return new int[] { -1, -1 };
    }
}
