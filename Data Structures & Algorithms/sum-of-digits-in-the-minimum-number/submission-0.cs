public class Solution {
    public int SumOfDigits(int[] nums) {
        int n = nums.Length;
        int min = nums[0]; // we start by assuming the first element is the minimum

        // 1. Find the true minimum number in the array
        for (int i = 0; i < n; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        // 2. Sum the digits of the minimum number
        int digitSum = 0;
        while (min > 0)
        {
            digitSum += min % 10; 
            min /= 10;
        }

        // 3. 
        return (digitSum % 2 == 0) ? 1 : 0; 

    }
}
