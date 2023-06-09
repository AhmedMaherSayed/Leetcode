/**
 * @param {character[]} letters
 * @param {character} target
 * @return {character}
 */
var nextGreatestLetter = function(letters, target) {
    let min = '';
    if(letters[letters.length -1] <= target)
        {
            min = letters[0];
        }
    for (let i = 0; i < letters.length; i++)
        {
            if(letters[i] > target)
                {
                    min = letters[i];
                    break;
                }
        }
    
    return min;
};