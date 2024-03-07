public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int maxLength = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char rightChar = s[right];

            if (charIndexMap.TryGetValue(rightChar, out int prevIndex)) 
            {
                left = Math.Max(left, prevIndex + 1);
            }

            charIndexMap[rightChar] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
