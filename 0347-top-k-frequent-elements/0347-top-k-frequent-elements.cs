public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
for(var i = 0; i < nums.Length; i++)
{
    if (!dic.ContainsKey(nums[i]))
        dic.Add(nums[i], 1);
    else
        dic[nums[i]]++;
}
var result = dic
    .OrderByDescending(x => x.Value)
    .Select(x => x.Key)
    .Take(k)
    .ToArray();   

        return result;     
        }
        
}