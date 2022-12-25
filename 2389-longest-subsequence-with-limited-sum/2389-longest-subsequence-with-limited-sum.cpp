class Solution {
public:
    vector<int> answerQueries(vector<int>& nums, vector<int>& queries) {
        vector<int> ans;
        sort(nums.begin() , nums.end());
        
        int sum = 0;
        int flag;
        for(int i = 0; i < queries.size(); i++)
        {
            for(int j = 0; j < nums.size(); j++)
            {
                if(sum + nums[j] <= queries[i])
                {
                    sum += nums[j];
                    flag++;
                }
                else
                {
                    break;
                }
            }
            ans.push_back(flag);
            flag = 0;
            sum = 0;
        }
        return ans;
    }
};