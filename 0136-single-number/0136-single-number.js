/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    let size = nums.length;
    nums.sort();
    for(let i = 1; i < size; i++)
        {
            if(nums[i - 1] === nums[i])
                {
                    nums.splice(i - 1 , 2);
                    size -= 2;
                    i -= 2;
                }
        }
    return nums;
};