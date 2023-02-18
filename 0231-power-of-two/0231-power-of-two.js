/**
 * @param {number} n
 * @return {boolean}
 */
var isPowerOfTwo = function(n) {
    let soln = 0;
    
    if(Math.log2(n) - Math.ceil(Math.log2(n)) === 0)
        {
            return true;
        }
    else
        {
            return false;
        }
};