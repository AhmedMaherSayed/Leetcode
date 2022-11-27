class Solution {
public:
    int findGCD(vector<int>& nums) {
        int ans;
        int max = 1; 
        int min = 1000;
        for(int i = 0; i < nums.size(); i++)
        {
            if(max < nums[i])
            {
                max = nums[i];
            }
            if(min > nums[i])
            {
                min = nums[i];
            }
        }
        for(int i = 1; i <= min; i++)
        {
            if(min % i == 0 && max % i == 0)
            {
                ans = i;
            }
        }
        return ans;
    }
};