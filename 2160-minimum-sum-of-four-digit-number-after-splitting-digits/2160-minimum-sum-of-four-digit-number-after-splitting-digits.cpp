class Solution {
public:
    int minimumSum(int num) {
       vector<int> nums(4);
        int x = 0;
        int y = 0;
        
        for(int i = 0; i < 4; i++)
        {
            nums[i] = num % 10;
            num /= 10;
        }
        sort(nums.begin() , nums.end());
        x += nums[0] * 10;
        x += nums[2];
        y += nums[1] * 10;
        y += nums[3];
        return x + y;

    }
};