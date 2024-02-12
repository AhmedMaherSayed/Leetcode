public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<int, int>();
    for(var i = 0; i < nums.Length; i++)
    {
        if (!dic.ContainsKey(nums[i]))
          dic.Add(nums[i], 1);
        else
         dic[nums[i]]++;
    }
    var result = dic.OrderByDescending(x => x.Value).FirstOrDefault();
    return result.Key;
    }
}