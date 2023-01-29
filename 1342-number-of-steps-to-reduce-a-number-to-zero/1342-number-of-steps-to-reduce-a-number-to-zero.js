/**
 * @param {number} num
 * @return {number}
 */
var numberOfSteps = function(num) {
    let counter = 0;
    while(num)
        {
            if (num % 2 === 0)
                {
                    num = parseInt(num /2);
                    counter++;
                }
            else
                {
                    num--;
                    counter++;
                }
        }
    return counter;
};