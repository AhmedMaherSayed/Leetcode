class Solution {
public:
    vector<int> findErrorNums(vector<int>& nums) {
        vector<int> ans;
        int misssedNumber = 0;
        sort(nums.begin() , nums.end());
        if(nums[0] != 1)
        {
            misssedNumber = 1;
        }
        
        for(int i = 1; i < nums.size(); i++)
        {
            if(nums[i] == nums[i - 1])
            {
                ans.push_back(nums[i]);
            }
            
            if(nums[i] - nums[i - 1] > 1)
            {
                misssedNumber = nums[i] - 1;
            }
        }
        if(misssedNumber == 0)
        {
            misssedNumber = nums[nums.size() - 1] + 1;
        }
        ans.push_back(misssedNumber);
        return ans;
    }
};