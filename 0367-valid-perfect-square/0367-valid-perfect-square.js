/**
 * @param {number} num
 * @return {boolean}
 */
var isPerfectSquare = function(num) {
    if(Math.sqrt(num) === parseInt(Math.sqrt(num)))
        {
            return true;
        }
    else
        {
            return false;
        }
};