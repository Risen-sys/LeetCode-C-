public class Solution {
    public int LengthOfLongestSubstring(string s) {
       if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            List<char> list = new List<char>();
            int max = 0;
            int i = 0;
            int j = 0;
            while (i < s.Length)
            {
                if (!list.Contains(s[i]))
                {
                    list.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, list.Count);
                    list.Remove(s[j]);
                    j++;
                }
            }
            max = Math.Max(max, list.Count);
            return max;
    }
}