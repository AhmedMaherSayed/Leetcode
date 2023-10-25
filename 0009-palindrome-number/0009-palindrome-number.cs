public class Solution {
    public bool IsPalindrome(int x) {
        int reversedNum = 0;
        bool result;
        int temp = x;
        if(x < 0)
        {
            result = false;
        }
        else
        {
            while(temp != 0)
            {
                reversedNum = reversedNum * 10 + temp % 10;
                temp /= 10; 
            }
            if(x == reversedNum)
                result = true;
            else
            result = false;
        }

        return result;
        
    }
}