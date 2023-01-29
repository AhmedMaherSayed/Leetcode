class Solution {
public:
    int countDigits(int num) {
        int test = num;
        int flag;
        int counter = 0;
        while(test)
        {
            flag = test % 10;
            if(num % flag == 0)
            {
                counter++;
            }
            test /= 10;
        }
        return counter;
    }
};