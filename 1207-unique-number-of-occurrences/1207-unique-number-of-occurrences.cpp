class Solution {
public:
    bool uniqueOccurrences(vector<int>& arr) {
        vector<int> ans;
        int counter = 0;
        sort(arr.begin() , arr.end());
        if(arr.size() == 2 && arr[0] != arr[1])
        {
            return false;
        }
            
        for(int i = 1; i < arr.size(); i++)
        {
            if(arr[i] == arr[i - 1])
            {
                counter++;
            }
            else
            {
                ans.push_back(counter);
                counter = 0;
            }
        }
        sort(ans.begin() , ans.end());
        for(int i = 1; i < ans.size(); i++)
        {
            if(ans[i] == ans[i - 1])
            {
                return false;
            }
        }
        return true;
    }
};