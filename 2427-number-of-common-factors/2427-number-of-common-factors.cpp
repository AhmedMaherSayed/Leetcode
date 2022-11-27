class Solution {
public:
    int commonFactors(int a, int b) {
        int counter = 0;
        int temp;
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        
        for(int i = 1; i <= b; i++)
        {
            if ( a % i == 0 && b % i == 0)
            {
                counter++;
            }
        }
        return counter;
    }
};