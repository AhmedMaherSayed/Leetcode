public class Solution {
    public int FirstUniqChar(string s) {
  var dic = new Dictionary<char, int>();
  int index = -1;
  for (int i = 0; i < s.Length; i++)
  {
      if (!dic.ContainsKey(s[i]))
          dic.Add(s[i], 1);
      else if (dic.ContainsKey(s[i]))
          dic[s[i]]++;
  }
  for(var i = 0; i < s.Length; i++)
  {
      if (dic[s[i]] == 1)
      {
          index = i;
          break;
      }
  }
        return index;
    }
}