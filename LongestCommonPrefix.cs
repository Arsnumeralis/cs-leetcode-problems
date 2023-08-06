// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string CompareMethod(string prefix, string word)
        {
            string common = "";
            for (int i = 0; i < Math.Min(prefix.Length, word.Length) && prefix[i] == word[i]; i++)
            {
                common += prefix[i];
            }
            return common;
        }
        string prefix = "";
        for (int i = 0; i < strs.Length; i++)
        {
            if (i == 0)
            {
                prefix += strs[i];
            }
            prefix = CompareMethod(prefix, strs[i]);
            if (prefix == "")
            {
                return prefix;
            }
        }
        return prefix;
    }
}