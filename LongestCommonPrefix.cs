// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        List<string> prefixes = new List<string>();
        int shortestLength = strs.Min(w => w.Length);
        string shortestWord = strs.FirstOrDefault(w => w.Length == shortestLength);
        bool check = true;
        int i = 0;
        string prefix = string.Empty;
        while (check == true && i < shortestLength)
        {
            if (strs.All(el => el[i] == shortestWord[i]))
            {
                prefix += shortestWord[i];
                i++;
            }
            else
            {
                check = false;
            }
        }
        return prefix;
    }
}