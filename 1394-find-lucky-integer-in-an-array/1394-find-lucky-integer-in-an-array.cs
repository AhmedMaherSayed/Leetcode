public class Solution {
    public int FindLucky(int[] arr) {
            var dic = new Dictionary<int,int>();
            int ans = -1;
            foreach (var num in arr)
            {
                if (!dic.ContainsKey(num))
                    dic.Add(num, 1);
                else
                    dic[num]++;
            }

            foreach (var e in dic)
{
    if (e.Key == e.Value)
        ans = e.Value;  
}
    return ans;
    }
}