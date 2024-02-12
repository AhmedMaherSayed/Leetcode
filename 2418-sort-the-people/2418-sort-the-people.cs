public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        var dic = new Dictionary<int, string>();
        for(var i = 0; i < names.Length; i++)
        dic.Add(heights[i], names[i]);

        var result = dic.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray();
        return result;
    }
}