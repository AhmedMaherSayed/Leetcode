public class Solution {
    public int LengthOfLastWord(string s) {
        string s1 = s.Trim();
        return s1.Length - 1 - s1.LastIndexOf(' ');
    }
}