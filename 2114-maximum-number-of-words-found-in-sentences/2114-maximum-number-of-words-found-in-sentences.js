/**
 * @param {string[]} sentences
 * @return {number}
 */
var mostWordsFound = function(sentences) {
   let counter = 0;
    let maxWords = 0;
    for(let i = 0; i < sentences.length; i++)
        {
            for(let j = 0; j < sentences[i].length; j++)
                {
                    if(sentences[i][j] === ' ')
                        {
                            counter++;
                        }
                }
            if(counter > maxWords)
                {
                    maxWords = counter;
                }
            counter = 0;
        }
    return maxWords + 1;
};