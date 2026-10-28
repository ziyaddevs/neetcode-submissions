public class Solution {
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int n = nums.Length;


        foreach(int num in nums)
        {
            if(!count.ContainsKey(num))
            {
                count[num] = 0;
            }
            count[num]++;


            if(count[num] > n / 2)
            {
                return num;
            }
        }
        return -1;
    }
}