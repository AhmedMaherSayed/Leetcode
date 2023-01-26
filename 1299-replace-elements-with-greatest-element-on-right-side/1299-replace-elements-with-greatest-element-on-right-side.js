/**
 * @param {number[]} arr
 * @return {number[]}
 */
var replaceElements = function(arr) {
    let soln = [];
    let max = 0;
    for(let i = 0; i < arr.length -1; i++)
        {
            for(let j = i + 1 ; j < arr.length; j++)
                {
                    if(max < arr[j])
                        {
                            max = arr[j];
                        }
                }
            soln.push(max);
            max = 0;
        }
    soln.push(-1);
    return soln;
};