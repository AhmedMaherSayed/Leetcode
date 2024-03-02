public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] ans = new int[nums.Length];
for(int i = 0; i < nums.Length; i++)
{
    ans[i] = ((int)Math.Pow(nums[i], 2));
}
Array.Sort(ans);
return ans;
    }
}