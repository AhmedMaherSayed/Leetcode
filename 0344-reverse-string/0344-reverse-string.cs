public class Solution {
    public void ReverseString(char[] s) {
        char[] ans = new char[s.Length];
for(var i = s.Length - 1; i >= 0; i--)
    ans[s.Length - 1 - i] = s[i];
   ans.CopyTo(s, 0);
    }
}