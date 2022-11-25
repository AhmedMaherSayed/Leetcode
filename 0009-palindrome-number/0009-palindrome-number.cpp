class Solution {
public:
    bool isPalindrome(int x) {
        long long temp = x, reversed = 0;
        if(x < 0)
        {
            return false;
        }
        else if (x > 0 && x < 10)
        {
            return true;
        }
        else
        {
            while(temp)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }
            if (reversed == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }
};