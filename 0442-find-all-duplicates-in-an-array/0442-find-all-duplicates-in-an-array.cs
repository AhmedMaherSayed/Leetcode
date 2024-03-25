public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        Array.Sort(nums);
        List<int> ans = new List<int>();

        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] == nums[i - 1])
                ans.Add(nums[i]);
        }
        return ans;
    }
}