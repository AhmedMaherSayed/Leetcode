public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       int[] ans = { -1, -1 };
    Dictionary<int, int> dic = new();

    for (int i = 0; i < nums.Length; i++)
    {
        dic[nums[i]] = i;
    }
    int temp = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        temp = target - nums[i];

        
        if (dic.ContainsKey(temp))
        {
            if (dic[temp] == i)
        continue;
         if(i > dic[temp])
            {
            ans[0] = dic[temp];
            ans[1] = i;
         }
        else
        {
            ans[0] = i;
            ans[1] = dic[temp];
        }
        
    }
    }
    return ans;
    }
}