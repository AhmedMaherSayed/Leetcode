/**
 * @param {number[]} nums
 * @return {number}
 */
var findDuplicate = function(nums) {
    let ans = 0;
    nums.sort();
    for(let i = 1; i < nums.length; i++)
        {
            if(nums[i] === nums[i - 1])
                {
                    ans = nums[i];
                }
        }
    return ans;
};