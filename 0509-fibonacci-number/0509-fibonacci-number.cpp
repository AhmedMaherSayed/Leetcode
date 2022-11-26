class Solution {
public:
    int fib(int n) {
        int fibPrev = 0;
        int fibNow = 1;
        int fibNext = 1;
        if (n == 0)
        {
            fibNext = 0;
        }
        else if (n == 1)
        {
            fibNext = 1;
        }
        else
        {
        for(int i = 2; i <= n; i++)
        {
            fibNext = fibNow + fibPrev;
            fibPrev = fibNow;
            fibNow = fibNext;
        }
        }
        return fibNext;
    }
};