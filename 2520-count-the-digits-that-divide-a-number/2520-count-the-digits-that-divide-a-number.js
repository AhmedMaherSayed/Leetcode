/**
 * @param {number} num
 * @return {number}
 */
var countDigits = function(num) {
    let counter = 0;
    let test = num;
    let temp;
    while(test)
        {
            temp = test % 10;
            if(num % temp === 0)
                {
                    counter++;
                }
            test = parseInt(test / 10);
        }
    return counter;
};