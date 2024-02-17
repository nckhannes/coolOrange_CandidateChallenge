using System;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            return IsPalindromeChecker(s, 0,s.Length-1);

        }

        public static bool IsPalindromeChecker(string s, int anfang, int ende)
        {
            if (s == "" || anfang == ende || s.Length == 2 && s[anfang] == s[ende]) 
            {
                return true;
            }
            if (s[anfang] != s[ende])
            {
                return false;
            }
            return IsPalindromeChecker(s, anfang+1, ende - 1);
        }
    }
}
