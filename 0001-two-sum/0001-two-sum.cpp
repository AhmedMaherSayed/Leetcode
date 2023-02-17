class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int,int> me;
        
        vector<int> vct;

        for(int i=0;i<nums.size();i++)
        {
            if(me.find(target - nums[i]) != me.end()){
                vct.push_back(me[target-nums[i]]);
                vct.push_back(i);
                break;
            }
            me[nums[i]] = i;
        }
        return vct;

    }
};