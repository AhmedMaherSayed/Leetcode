class Solution {
public:
    int arraySign(vector<int>& nums) {
        int product = 1;
        for(int i = 0; i < nums.size(); i++)
        {
            if(nums[i] == 0)
            {
                return 0;
            }
            else if(nums[i] > 0)
            {
                product *= 1;
            }
            else if(nums[i] < 0)
            {
                product *= -1;
            }
        }
        if(product > 0)
        {
            return 1;
        }
        else 
        {
            return -1;
        }
       
    }
};