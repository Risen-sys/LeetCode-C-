public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        string[] letters = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        IList<string> list = new List<string>();
        if (digits.Length==0){return list;}
        list.Add("");

        for (int i = 0; i < digits.Length; i++)
        {
            int index = (int)char.GetNumericValue(digits[i]);

            while (list[0].Length==i)
            {
                string first = list[0];
                list.RemoveAt(0);

                foreach (char c in letters[index].ToCharArray())
                {
                    list.Add(first + c);
                }
            }
        }
        return list;    
    }
}