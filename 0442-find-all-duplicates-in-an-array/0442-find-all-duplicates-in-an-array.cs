public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var dic = new Dictionary<int, int>();
for(var i = 0; i < nums.Length; i++)
{
    if (!dic.ContainsKey(nums[i]))
        dic.Add(nums[i], 1);
    else
        dic[nums[i]]++;
    
}

var ans = dic.Where(num => num.Value > 1).Select(num => num.Key).ToList();
return ans;
    }
}