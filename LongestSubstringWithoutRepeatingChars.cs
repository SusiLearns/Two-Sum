using System.Globalization;
using System.Text;

public class LongestSubstringWithoutRepeatingChars
{
    public int GetLongestSubstringWithoutRepeatingChars(string s)
    {
        int maxLength = 0;

        for ( int i = 0; i < s.Length ; i++)
        {
            StringBuilder sb = new StringBuilder();
            for ( int j = 0; j < s.Length ; j++)
            {
       if(sb.ToString().Contains(s[j]))
       {
            break;
       }

       sb.Append(s[j]);
       maxLength = Math.Max(maxLength, sb.Length);
            }
        }
        return maxLength;
    }
}