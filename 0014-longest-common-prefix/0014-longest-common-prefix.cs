public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            if (strs is null || strs.Length == 0)
                return string.Empty;

            Array.Sort(strs);

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (i >= strs[strs.Length - 1].Length || strs[0][i] != strs[strs.Length - 1][i])
                    return strs[0].Substring(0, i);
            }

            return strs[0];  
    }
}