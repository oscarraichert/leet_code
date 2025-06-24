namespace Services;

public class PalindromeServices
{
    // "A man, a plan, a canal: Panama"
    public static bool ValidPalindrome(string s)
    {
        var chars = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            var current = s[i];

            if ((current >= 'a' && current <= 'z') || (current >= '0' && current <= '9'))
            {
                chars.Add(current);
            }

            else if (current >= 'A' && current <= 'Z')
            {
                chars.Add((char)(current + 32));
            }
        }

        for (int i = 0, j = chars.Count - 1; i < chars.Count / 2; i++, j--)
        {
            if (chars[i] != chars[j])
            {
                return false;
            }
        }  

        return true;
    }
}
