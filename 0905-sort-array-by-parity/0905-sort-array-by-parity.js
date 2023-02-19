/**
 * @param {number[]} nums
 * @return {number[]}
 */
var sortArrayByParity = function(nums) {
    let ans = [];
    for(let i = 0; i < nums.length; i++)
        {
            if(nums[i] % 2 === 0)
                {
                    ans.push(nums[i]);
                }
        }
    for(let i = 0; i < nums.length; i++)
        {
            if(nums[i] % 2 !== 0)
                {
                    ans.push(nums[i]);
                }
        }
    return ans;
};