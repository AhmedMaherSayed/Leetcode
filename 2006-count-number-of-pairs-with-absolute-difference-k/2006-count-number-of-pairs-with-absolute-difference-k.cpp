class Solution {
public:
    int countKDifference(vector<int>& nums, int k) {
        int counter = 0;
        for(int i = 0; i < nums.size(); i++)
        {
            for(int j = i + 1; j < nums.size(); j++)
            {
                if(j != i)
                {
            
                if(nums[i] - nums[j] == k || (nums[i] - nums[j]) * -1 == k )
                {
                    counter++;
                }
                }
            }
        }
        return counter;
    }
};