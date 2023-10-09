class Solution {
public:
    vector<int> searchRange(vector<int>& nums, int target) {
        vector<int> ans;
        sort(nums.begin() , nums.end());
        for(int i = 0; i < nums.size() ; i++)
        {
            if (nums[i] == target)
            {
                ans.push_back(i);
            }
        }
        if (ans.size() == 0)
        {
            return {-1 , -1};
        }
        else if (ans.size() == 1)
        {
            ans.push_back(ans[0]);
            return ans;
        }
        else if (ans.size() > 2)
        {
            return {ans[0] , ans[ans.size() - 1]}; 
        }
        else
        {
            return ans;
        }
    }
};