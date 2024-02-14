public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int pos = 0;
int neg = 1;
int[] ans = new int[nums.Length];
for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0)
    {
        ans[pos] = nums[i];
        pos += 2;
    }
    else
    {
        ans[neg] = nums[i];
        neg += 2;
    }
}
return ans;
    }
}