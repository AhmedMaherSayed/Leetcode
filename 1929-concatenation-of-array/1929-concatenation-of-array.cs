public class Solution {
    public int[] GetConcatenation(int[] nums) {
            int capacity = nums.Length;
            int[] ans = new int[capacity * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + capacity] = nums[i];
            }
            return ans; 
    }
}