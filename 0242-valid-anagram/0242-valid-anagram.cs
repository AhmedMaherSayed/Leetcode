public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        if (sArr.Length != tArr.Length)
            return false;

        for (int i = 0; i < sArr.Length; i++)
        {
            if (sArr[i] != tArr[i])
                return false;
        }
        return true;
    }
}