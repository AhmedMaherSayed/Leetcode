/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    nums.sort();
    let max = 0;
    let temp = 0;
    let element = nums[0];
    for(let i = 0; i < nums.length; i++)
        {
            for(let j = 1; j < nums.length; j++)
                {
                    if(nums[i] === nums[j])
                        {
                            temp++;
                        }
                }
            if(max < temp)
                {
                    max = temp;
                    element = nums[i];
                }
            temp = 0;
        }
    return element;
};