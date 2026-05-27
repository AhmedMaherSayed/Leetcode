public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // HashMap ✅ Optimal
         var seen = new Dictionary<int, int>(nums.Length); // pre-sized

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        if (seen.TryGetValue(complement, out int j))
            return [j, i];

        seen[nums[i]] = i;
    }

    return [];
    }
}