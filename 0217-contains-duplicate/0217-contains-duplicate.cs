public class Solution {
        public bool ContainsDuplicate(int[] nums) {
             var seen = new HashSet<int>(nums.Length); // pre-size to avoid rehashing

 foreach (int num in nums)
 {
     if (seen.Contains(num))
         return true;

     seen.Add(num);
 }

 return false;
        }
}