public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>(nums.Length);
        int diff = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];

            if (seen.TryGetValue(diff, out int idx))
                return [idx, i];
            
            seen[nums[i]] = i;
        }

        return [];
    }
}