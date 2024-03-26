public class Solution {
    public int MissingNumber(int[] nums) {
        int missedNum = -1;
for(var i = 0; i < nums.Length; i++)
{
    if (!nums.Contains(i))
        missedNum = i;
}
if(missedNum == -1)
    missedNum = nums.Length;
    else if(!nums.Contains(0))
    missedNum = 0;
    return missedNum;
    }
}