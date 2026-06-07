public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexed = nums.Select((val, idx) => (val, idx))
                          .OrderBy(x => x.val)
                          .ToArray();

     int leftPtr = 0;
     int rightPtr = nums.Length - 1;
    int sum = 0;
     while (leftPtr < rightPtr)
     {
        sum = indexed[leftPtr].val + indexed[rightPtr].val;

        if (sum == target)
            return [indexed[leftPtr].idx, indexed[rightPtr].idx];
        else if (sum > target)
            rightPtr--;
        else if (sum < target)
            leftPtr++;
     }

     return [];
    }
}