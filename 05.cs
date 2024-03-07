public class Solution {
    public string LongestPalindrome(string s) 
    {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0, end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int len = s.Length - i; len > 1; len--)
            {
                if (IsPalindrome(s, i, i + len - 1))
                {
                    if (len > end - start + 1)
                    {
                        start = i;
                        end = i + len - 1;
                    }
                    break; 
                }
            }

            if ((end - start + 1) > (s.Length - i - 1)) 
            {
                break; 
            }
        }

        return s.Substring(start, end - start + 1);
    }

    private static bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start++] != s[end--])
            {
                return false;
            }
        }
        return true;
    }

}