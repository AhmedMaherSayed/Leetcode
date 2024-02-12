public class Solution {
    public IList<int> MajorityElement(int[] nums) {
    var dic = new Dictionary<int, int>();
for(var i = 0; i < nums.Length; i++)
{
    if (!dic.ContainsKey(nums[i]))
        dic.Add(nums[i], 1);
    else
        dic[nums[i]]++;
}
var result = (from element in dic
             where element.Value > nums.Length / 3
             select element.Key).ToList<int>();

    return result;
    }
}