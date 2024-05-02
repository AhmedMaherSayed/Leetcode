public class Solution {
    public int FindMaxK(int[] nums) {
        int sol = -1;
Array.Sort(nums);
var result = nums.Distinct().ToHashSet();
foreach (int num in result)
{
    if (result.Contains(num * -1))
        sol = num;
}
return sol;
    }
}