/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDuplicates = function(nums) {
    nums.sort();
    let ans = [];
    
    for(let i = 1; i < nums.length; i++)
        {
            if(nums[i] === nums[i - 1])
                {
                    ans.push(nums[i]);
                }
        }
    return ans;
};