namespace Services;

public class ReverseStringService
{
    public static char[] ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            var j = s.Length - i - 1;

            if (i >= j)
            {
                break;
            }

            var currentTail = s[j];

            s[j] = s[i];
            s[i] = currentTail;
        }

        return s;
    }
}
