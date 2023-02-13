class Solution {
public:
    int countOdds(int low, int high) {
        int counter = 0;
        for(int i = low; i <= high; i++)
        {
            if(i % 2 != 0)
            {
                counter++;
            }
        }
        return counter;
    }
    
};