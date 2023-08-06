// Given a Roman numeral, convert it to an integer.

public class Solution
{
    Dictionary<char, int> romanNumDict = new Dictionary<char, int>()
        {
            {'I',1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };
    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanNumDict[s[i]] < romanNumDict[s[i + 1]])
            {
                result -= romanNumDict[s[i]];
            }
            else
            {
                result += romanNumDict[s[i]];
            }
        }
        return result;
    }
}