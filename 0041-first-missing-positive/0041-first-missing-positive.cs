public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
int ans = 1;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == ans)
        ans++;
}
return ans;
    }
}