public class Solution {
    public string LongestCommonPrefix(string[] words) {
            var possiblePrefix = words[0];
            
            for (var i = 1; i < words.Length; i++)
            {
                var current = words[i];
                
                while (!current.StartsWith(possiblePrefix) && possiblePrefix.Length > 0)
                {
                    possiblePrefix = possiblePrefix.Remove(possiblePrefix.Length - 1);
                }
            }

            return possiblePrefix;
    }
}