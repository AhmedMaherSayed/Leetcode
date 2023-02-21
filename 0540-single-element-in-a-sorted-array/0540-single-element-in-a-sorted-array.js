/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNonDuplicate = function(nums) {
    let size = nums.length;
    for(let i = 1; i < size; i++)
        {
            if(nums[i] === nums[i - 1])
                {
                    nums.splice(i - 1, 2);
                    i--;
                    size--;
                }
        }
    return nums;
};