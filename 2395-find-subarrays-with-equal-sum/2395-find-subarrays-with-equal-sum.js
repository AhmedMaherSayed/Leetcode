/**
 * @param {number[]} nums
 * @return {boolean}
 */
var findSubarrays = function(nums) {
    for(let i = 0; i < nums.length; i++)
        {
            for(let j = i; j < nums.length; j++)
                {
                    if(nums[i] + nums[i + 1] === nums[j] + nums[j + 1] && i !==j)
                        {
                             return true;
                        }
                       
                }
        }
    return false;
};