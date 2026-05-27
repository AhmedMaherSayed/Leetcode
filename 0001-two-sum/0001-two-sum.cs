public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Sort + Two Pointers
       var indexed = nums.Select((val, idx) => (val, idx))
                        .OrderBy(x => x.val)
                        .ToArray();

        int leftPointer = 0;
        int rightPointer = indexed.Length - 1;

        while (leftPointer < rightPointer)
        {
            int sum = indexed[leftPointer].val + indexed[rightPointer].val;

            if (sum == target)
                return [indexed[leftPointer].idx, indexed[rightPointer].idx];
            else if (sum < target)
                leftPointer++;
            else
                rightPointer--;
        }
        return [];
    }
}