public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(!map.ContainsKey(complement))
            {
                map.Add(nums[i], i);
            }
            else
            {
                return new int[] { map[complement], i};
            }
        }
        return new int[] { -1, -1};
    }
}
