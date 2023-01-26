/**
 * @param {number[][]} accounts
 * @return {number}
 */
var maximumWealth = function(accounts) {
    let max = 0;
    let sum = 0;
    for(let i = 0; i < accounts.length; i++)
        {
            for(let j = 0; j < accounts[i].length; j++)
                {
                    sum += accounts[i][j];
                }
            if(max < sum)
                {
                    max = sum;
                }
            sum = 0;
        }
    return max;
};