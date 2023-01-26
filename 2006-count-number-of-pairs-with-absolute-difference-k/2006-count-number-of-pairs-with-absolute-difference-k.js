/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */

var countKDifference = function(nums, k) {
    let counter = 0;
    for(let i = 0; i < nums.length; i++)
        {
            for(let j = i; j < nums.length; j++)
                {
                    if(nums[i] - nums[j] === k || nums[j] - nums[i] === k )
                        {
                            counter++;
                        }
                }
        }
    return counter;
};