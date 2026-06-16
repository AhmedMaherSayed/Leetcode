public class Solution {
    public int RemoveElement(int[] nums, int val) {
            int ans = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[ans] = nums[i];
                    ans++;
                }
            }

            return ans;
    }
}