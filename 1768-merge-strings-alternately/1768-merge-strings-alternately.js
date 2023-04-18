/**
 * @param {string} word1
 * @param {string} word2
 * @return {string}
 */
var mergeAlternately = function(word1, word2) {
    let temp = '';
    let ans = [];
    if (word2.length > word1.length)
        {
            temp = word1;
            word1 = word2;
            word2 = temp;
            for(let i = 0; i < word1.length; i++)
        {
             
            if (word2.length > i)
                {
                    ans.push(word2[i]);
                }
            ans.push(word1[i]);
        }
        }
    else
        {
    for(let i = 0; i < word1.length; i++)
        {
             ans.push(word1[i]);
            if (word2.length > i)
                {
                    ans.push(word2[i]);
                }
        }
            }
    return ans.join('');
};