/**
 * @param {number[]} nums
 * @return {number[]}
 */
var majorityElement = function(nums) {
    nums.sort();
    let counter = 0;
    let ans = [];
    let element = -10000000000;
    for(let i = 0; i < nums.length; i++)
        {
            for(let j = i; j < nums.length; j++)
                {
                    if(nums[i] == nums[j])
                        {
                            counter++;
                        }
                }
            if(counter > (nums.length / 3) && element !== nums[i])
                {
                    ans.push(nums[i]);
                    element = nums[i];
                }
            counter = 0;
        }
    return ans;
};