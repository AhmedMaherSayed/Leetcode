public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ans = {-1, -1};
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1;j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    ans[0] = i;
                    ans[1] = j;
                }
            }
        }
        return ans;
    }
}