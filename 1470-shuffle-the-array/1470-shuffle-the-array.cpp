class Solution {
public:
    vector<int> shuffle(vector<int>& nums, int n) {
        int temp = n;
        int val = 0;
        for(int i = 0; i< nums.size() ; i++)
        {
            if(i % 2 != 0)
            {
                val = nums[temp];
                nums.erase(nums.begin() +temp);
                nums.insert(nums.begin() + i, val);
                
                temp++;
            }
        }
        return nums;
        /*for(int i = n; i < nums.size() - 1; i ++)
        {
            nums.insert()
        }*/
    }
};