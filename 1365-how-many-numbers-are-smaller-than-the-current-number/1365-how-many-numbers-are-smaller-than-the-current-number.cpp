class Solution {
public:
    vector<int> smallerNumbersThanCurrent(vector<int>& nums) {
        int n = nums.size();
        vector<int> ans(n);
        int flag = 0;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(nums[i] > nums[j] && i != j)
                {
                    flag++;
                }
            }
            ans[i] = flag;
            flag = 0;
        }
        return ans;
    }
};