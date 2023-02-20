/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
   if( nums.includes(target) === true)
       {
           return nums.indexOf(target);
       }
    else if(nums[nums.length - 1] < target)
        {
            return nums.length;
        }
    else
        {
            for(let i = 0; i < nums.length; i++)
                {
                    if(nums[i] >= target)
                        {
                            return i;
                        }
                }
        }
};