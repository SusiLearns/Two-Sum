//Given 2 strings s and t, return true if t is anagram of a , and false otherwise
/*
Example --> EAR, ERA --> Both words are having all letters
--> EAR, TAR --> Not having the letters.
*/
using System;
using System.Runtime.CompilerServices;
public class Anagram
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;

        var sCharArray = s.ToLower().ToCharArray();
        var tCharArray = t.ToLower().ToCharArray();
        Array.Sort(sCharArray);
        Array.Sort(tCharArray);
        var string_s = new String(sCharArray);
        var string_t = new String(tCharArray);

        return string_s == string_t;
    }
}