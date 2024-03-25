public class Solution {
    public int FindDuplicate(int[] nums) {
        int ans = -1;
        Array.Sort(nums);

        for(var i = 0; i < nums.Length -1; i++)
        {
            if(nums[i] == nums[i+ 1])
            {
                ans = nums[i];
            }
        }
        return ans;
    }
}