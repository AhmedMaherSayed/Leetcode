/**
 * @param {string} s
 * @param {number} k
 * @return {string}
 */
var truncateSentence = function(s, k) {
    let str = '';
    let counter = 0;
    for(let i = 0; i < s.length; i++)
        {
            if(counter < k)
                {
                    if(s[i] === ' ')
                        {
                            counter++;
                        }
                    str += s[i];
                }
        }
    return str.trim();
};