public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string str1 = "";
        string str2 = "";
        foreach(string str in word1)
        {
            str1 += str;
        }
        foreach(string str in word2)
        {
            str2 += str;
        }

        if(str1 == str2)
            return true;
        else
            return false;
    }
}