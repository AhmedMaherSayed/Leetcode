public class Solution {
    public int[] RunningSum(int[] nums) {
            int[] ans = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i] + sum;
                sum += nums[i];
            }
            return ans; 
    }
}