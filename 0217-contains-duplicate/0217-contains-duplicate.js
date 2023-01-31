/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    let counter = 0;
   nums.sort();
    for(let i = 1; i < nums.length; i++)
        {
            if(nums[i] === nums[i -1])
                {
                    return true;
                }
        }
    return false;
}