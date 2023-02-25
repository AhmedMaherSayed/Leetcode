/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
    let size = nums.length;
    for(let i = 0; i < size; i++)
        {
            if(nums[i] === val)
                {
                    nums.splice(i , 1);
                    i--;
                    size--;
                }
                
        }
    return nums.length;
};