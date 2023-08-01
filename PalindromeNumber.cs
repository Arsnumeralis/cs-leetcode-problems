// Given an integer x, return true if x is a palindrome, and false otherwise.

public class Solution
{
    public bool IsPalindrome(int x)
    {
        string digString = x.ToString();
        char[] digArray = digString.ToCharArray();
        string reverse = String.Empty;
        for (int i = digArray.Length - 1; i > -1; i--)
        {
            reverse += digArray[i];
        };
        int revInt;
        if (Int32.TryParse(reverse, out revInt))
        {
            ;
            if (x != revInt)
            {
                return false;
            };
            return true;
        }
        return false;
    }
}