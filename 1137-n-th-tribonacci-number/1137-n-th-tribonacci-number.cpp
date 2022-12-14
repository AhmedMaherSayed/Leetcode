class Solution {
public:
    int tribonacci(int n) {
        int t0 = 0, t1 = 1, t2 = 1, tNow;
        if (n <= 1)
        {
            return n;
        }
        else if (n == 2)
        {
            return 1;
        }
        for(int i = 3; i <= n; i++)
        {
            tNow = t2 + t1 + t0;
            t0 = t1;
            t1 = t2;
            t2 = tNow;
        }
        return tNow;
    }
};