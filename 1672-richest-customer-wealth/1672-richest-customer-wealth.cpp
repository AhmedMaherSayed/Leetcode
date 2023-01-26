class Solution {
public:
    int maximumWealth(vector<vector<int>>& accounts) {
        int max = 0;
        int sum = 0;
        
        for(int i = 0; i <accounts.size(); i++)
        {
            for(int j = 0; j < accounts[i].size(); j++)
            {
                sum += accounts[i][j];
            }
            if(max < sum)
            {
                max = sum;
            }
            sum = 0;
        }
        return max;
    }
};