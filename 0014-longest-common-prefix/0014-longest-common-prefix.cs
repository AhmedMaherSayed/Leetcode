public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            if (strs is null || strs.Length == 0)
                return string.Empty;

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length ||strs[0][i] != strs[j][i])
                        return strs[0][..i];
                }
            }

            return strs[0];  
    }
}