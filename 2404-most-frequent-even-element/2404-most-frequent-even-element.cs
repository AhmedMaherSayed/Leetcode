public class Solution {
    public int MostFrequentEven(int[] nums) {
        var dic = new Dictionary<int, int>();
    for(var i = 0; i < nums.Length; i++)
    {
        if (!dic.ContainsKey(nums[i]))
         dic.Add(nums[i], 1);
        else
            dic[nums[i]]++;
    }
    var RESULT = dic
        .Where(x => x.Key % 2 == 0)
        .OrderByDescending(x => x.Value)
        .ThenBy(x => x.Key)
        .FirstOrDefault();
        
        if(RESULT.Key == 0 && !dic.ContainsKey(0))
            return -1;

        return RESULT.Key;
    }
}