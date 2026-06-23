public class Solution {
    public string LongestCommonPrefix(string[] strs) {
             if (strs == null || strs.Length == 0)
                return string.Empty;

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                while (j < Math.Min(prefix.Length, strs[i].Length))
                {
                    if (prefix[j] != strs[i][j])
                        break;

                    j++;
                }
                prefix = prefix.Substring(0, j);
            }
            return prefix;       
    }
}