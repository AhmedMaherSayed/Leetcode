public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var dic = new Dictionary<char, int>();
int ans = 0;
for(int i = 0; i < jewels.Length; i++)
{
    if (!dic.ContainsKey(jewels[i]))
        dic.Add(jewels[i], 0);
}

for(int i = 0; i < stones.Length; i++)
{
    if (dic.ContainsKey(stones[i]))
        dic[stones[i]]++;
}
foreach (var i in dic.Values)
{
    ans += i;
}
return ans;
    }
}