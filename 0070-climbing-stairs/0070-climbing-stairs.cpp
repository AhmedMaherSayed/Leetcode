class Solution {
public:
    int climbStairs(int n) {
        int fibPrev = 1, fibNow = 1, fibNext;

        if (n == 1)
        {
            return 1;
        }
        for(int i = 2; i <= n; i++)
        {
            fibNext = fibPrev + fibNow;
            fibPrev = fibNow;
            fibNow = fibNext;
        }
        return fibNow;

    }
};