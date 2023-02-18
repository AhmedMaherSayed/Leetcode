/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    let arr1 = s.split('');
    let arr2 = t.split('');
    let counter = 0;
    arr1.sort();
    arr2.sort();
    if(arr1.length !== arr2.length)
        {
            return false;
        }
    for(let i = 0; i < arr1.length; i++)
    {
        if(arr1[i] !== arr2[i])
            {
                counter++;
            }
    
    }
    if(counter == 0)
        {
            return true;
            
        }
    else
        {
            return false;
        }
};