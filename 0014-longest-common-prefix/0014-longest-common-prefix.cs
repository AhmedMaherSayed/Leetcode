public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         for (int i = 0; i < strs[0].Length; i++) {
            foreach (string s in strs) {
                if (i == s.Length || s[i] != strs[0][i]) {
                    return s.Substring(0, i);
                }
            }
        }
        return strs[0];       
    }
}