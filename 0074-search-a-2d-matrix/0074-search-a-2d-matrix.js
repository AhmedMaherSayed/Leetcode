/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function(matrix, target) {
    let flag = false;
    for(let i = 0; i < matrix.length; i++)
        {
            for(let j= 0; j < matrix[i].length; j++)
                {
                    if(matrix[i][j] === target)
                        {
                            flag = true;
                        }
                }
        }
    return flag;
};