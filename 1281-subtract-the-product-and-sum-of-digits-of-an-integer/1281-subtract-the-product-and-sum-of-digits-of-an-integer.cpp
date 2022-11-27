class Solution {
public:
    int subtractProductAndSum(int n) {
        int sum = 0;
        int mul = 1;
        while(n)
        {
            sum += n % 10;
            mul *= n % 10;
            n /= 10;
        }
        return mul - sum;
    }
};